using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarmaDependentDialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue1, dialogue2;
    [SerializeField] private DialogueManager dm;
    [Header("Should player input be disabled during dialogue?")]
    [SerializeField] bool holdPlayer = true;
    [Header("Should dialogue disappear by itself?")]
    [SerializeField] bool hasTimer = false;
    [Header("How long should timer be?")]
    [SerializeField] float timerLength = 0f;
    [SerializeField] private int karmaForOption1, karmaForOption2;


    //the object this script is attached to will be the trigger for the dialogue. It could be a collider trigger, button, etc. or be called from another script for scripted cutscene events.

    public void Start()
    {
        //dm = FindObjectOfType<DialogueManager>();
    }

    //call this function by any method to start the dialogue, for example ontriggerenter
    public void TriggerDialogue()
    {
        dm.dialogueCanvas.SetActive(true);

        if (hasTimer)
        {
            if(KarmaManager.Karma == karmaForOption1)
            {
                dm.StartDialogueWithTimer(dialogue1, holdPlayer, timerLength);
            } else if(KarmaManager.Karma >= karmaForOption2)
            {
                dm.StartDialogueWithTimer(dialogue2, holdPlayer, timerLength);
            }
            
        }
        else
        {
            if (KarmaManager.Karma == karmaForOption1)
            {
                dm.StartDialogue(dialogue1, holdPlayer);
            }
            else if (KarmaManager.Karma >= karmaForOption2)
            {
                dm.StartDialogue(dialogue2, holdPlayer);
            }

        }

    }
}
