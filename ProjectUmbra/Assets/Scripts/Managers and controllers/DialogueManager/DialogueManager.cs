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
    private PlayerMovement pm;
    private float originalSpeed;

    private Dialogue current;

    private void Start()
    {
        sentences = new Queue<string>();
        pm = player.GetComponent<PlayerMovement>();
        originalSpeed = pm.getSpeed();
        
    }

    private void Update()
    {
        if (Input.anyKeyDown)
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
