using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Church2_CutsceneController : MonoBehaviour
{

    private bool play = false;
    private bool hasPlayedSet = false;
    public DialogueTrigger option1, option2;
    public DialogueManager playSetDialogue;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (!play)
        {
            //if player denied Set
            if (KarmaManager.Karma >= 100)
            {
                option2.TriggerDialogue();
                
            }
            else
            {
                option1.TriggerDialogue();
                option1.gameObject.SetActive(false);
                hasPlayedSet = true;
            }
            play = true;
        }
        
        if (playSetDialogue.Done && !hasPlayedSet)
        {
            option1.TriggerDialogue();
            option1.gameObject.SetActive(false);
            hasPlayedSet = true;
            this.gameObject.SetActive(false);
        }
    }
}
