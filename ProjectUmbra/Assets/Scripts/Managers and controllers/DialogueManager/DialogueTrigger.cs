using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    [SerializeField] private DialogueManager dm;
    [Header("Should player input be disabled during dialogue?")]
    [SerializeField] bool holdPlayer = true;

    //the object this script is attached to will be the trigger for the dialogue. It could be a collider trigger, button, etc. or be called from another script for scripted cutscene events.

    public void Start()
    {
        //dm = FindObjectOfType<DialogueManager>();
    }

    //call this function by any method to start the dialogue, for example ontriggerenter
    public void TriggerDialogue()
    {
        dm.dialogueCanvas.SetActive(true);

        dm.StartDialogue(dialogue, holdPlayer);
    }

}
