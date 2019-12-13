using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEvent : MonoBehaviour
{

    private DialogueTrigger currentTrigger;
    private int counter = 0;
    [SerializeField] private bool play = false;
    private bool started = false;
    [SerializeField] private CutsceneManager cm;

    private float originalSpeed;
    
    //Create a child for each "speaking turn". Give children DialogueTriggers with speaker name and sentences. Order the children in the order of conversation.


    void Start()
    {
        originalSpeed = ObjectHandeler.Player.GetComponent<PlayerMovement>().getSpeed();
        currentTrigger = transform.GetChild(counter).gameObject.GetComponent<DialogueTrigger>();

    }

    
    void Update()
    {
        if (play) { 
            if (!started && !currentTrigger.dialogue.getPlayedStatus())
            {
                
                if (currentTrigger.dialogue.getPlayNextVideo())
                {
                    cm.PlayNextVideo();
                }
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
                    ObjectHandeler.Player.GetComponent<PlayerMovement>().setSpeed(originalSpeed);
                    play = false;
                    this.gameObject.SetActive(false);
                    try {
                        cm.ShutOff();
                    }
                    catch (System.NullReferenceException)
                    {

                    }
                    
                }
                started = false;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ObjectHandeler.Player.GetComponent<PlayerMovement>().setSpeed(0);
            play = true;
        }
    }
}
