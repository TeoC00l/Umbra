using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEvent : MonoBehaviour
{

    private DialogueTrigger currentTrigger;
    private int counter = 0;
    private bool play = false;
    private bool started = false;

    
    //Create a child for each "speaking turn". Give children DialogueTriggers with speaker name and sentences. Order the children in the order of conversation.


    void Start()
    {
        currentTrigger = transform.GetChild(counter).gameObject.GetComponent<DialogueTrigger>();

    }

    
    void Update()
    {
        if (play) { 
            if (!started && !currentTrigger.dialogue.getPlayedStatus())
            {
                currentTrigger.TriggerDialogue();
                started = true;
            }
            else if(currentTrigger.dialogue.getPlayedStatus() && started) {
                counter++;
                try
                {
                    currentTrigger = transform.GetChild(counter).gameObject.GetComponent<DialogueTrigger>();
                }
                catch (UnityException e)
                {
                    play = false;
                    this.gameObject.SetActive(false);
                }
                started = false;
                //if(currentTrigger == null)
                //{
                //    play = false;
                //    this.gameObject.SetActive(false);
                //}
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            play = true;
        }
    }
}
