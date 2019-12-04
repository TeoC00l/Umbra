using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public GameObject dialogueCanvas;
    [SerializeField] private Image characterImage;
    [SerializeField] private Text nameText;
    [SerializeField] private Text dialogueText;
    [SerializeField] private GameObject player;
    [SerializeField] private Font OpenDyslexic;
    private PlayerMovement pm;
    private float originalSpeed;

    private Dialogue current;

    #region TextColours
    private Color aliceColor = new Color32(107, 200, 129, 255);
    private Color setColor = new Color32(127, 75, 153, 255);
    private Color ozColor = new Color32(230, 230, 230, 255);

    #endregion

    private void Start()
    {
        sentences = new Queue<string>();
        pm = player.GetComponent<PlayerMovement>();
        originalSpeed = pm.getSpeed();

        Debug.Log("Dialogue start");
        if(PlayerPrefs.GetInt("UseOpenDyslexic") == 1 || OptionSettingsStorage.OpenDyslexic == true)
        {
            Debug.Log("Font change");
            //Font OpenDyslexic = Resources.Load<Font>("OpenDyslexic.otf");
            //nameText.font = OptionSettingsStorage.GetOpenDyslexic();
            //dialogueText.font = OptionSettingsStorage.GetOpenDyslexic();
            dialogueText.fontSize = 18;
            dialogueText.font = OpenDyslexic;
        }
    }

    private void Update()
    {
        //if (Input.anyKeyDown)
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue, bool holdPlayer)
    {
        sentences.Clear();
        current = dialogue;
        //hold player
        if (holdPlayer)
        {
            pm.setSpeed(0);
        }
        nameText.text = dialogue.name;
        characterImage.sprite = dialogue.characterImage;

        switch (dialogue.name)
        {
            case "Alice":
                dialogueText.color = aliceColor;
                break;
            case "Set":
                dialogueText.color = setColor;
                break;
            case "Oz":
                dialogueText.color = ozColor;
                break;
            default:
                break;
        }

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void StartDialogueWithTimer(Dialogue dialogue, bool holdPlayer)
    {
        sentences.Clear();
        current = dialogue;
        //hold player
        if (holdPlayer)
        {
            pm.setSpeed(0);
        }
        nameText.text = dialogue.name;
        characterImage.sprite = dialogue.characterImage;

        foreach (string sent in dialogue.sentences)
        {
            sentences.Enqueue(sent);
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeTimedSentence(sentence));
    }


    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        //dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    IEnumerator TypeTimedSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            //yield return null;
        }
        yield return new WaitForSeconds(6f);
        EndDialogue();

    }

    void EndDialogue()
    {
        try
        {
            dialogueCanvas.SetActive(false);
            current.HasBeenPlayed(true);
            //release player
            pm.setSpeed(originalSpeed);
        } catch(System.NullReferenceException)
        {

        }
    }
}
