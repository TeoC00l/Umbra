using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Canvas dialogueCanvas;
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
        if (Input.GetKeyDown(KeyCode.Return))
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

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
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

    void EndDialogue()
    {
        dialogueCanvas.gameObject.SetActive(false);
        current.HasBeenPlayed(true);
        //release player
        pm.setSpeed(originalSpeed);
    }
}
