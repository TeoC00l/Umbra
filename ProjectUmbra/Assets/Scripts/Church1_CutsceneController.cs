using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Church1_CutsceneController : MonoBehaviour
{
    public PlayableDirector pd;
    public DialogueManager isDialogueDone_trigger;
    bool played = false;

    public DialogueTrigger dialogueToTriggerNext;
    void Start()
    {
        pd = ObjectHandeler.Alice.GetComponent<PlayableDirector>();
    }

    public IEnumerator PlayTimelineEvent()
    {
        pd.Play();
        yield return new WaitForSeconds(3);
        dialogueToTriggerNext.TriggerDialogue();
    }

    private void Update()
    {
        if(isDialogueDone_trigger.Done == true && !played){
            played = true;
            StartCoroutine(PlayTimelineEvent());
        }

    }

    public void InactivateOnSignal()
    {
        ObjectHandeler.Alice.SetActive(false);
    }
}
