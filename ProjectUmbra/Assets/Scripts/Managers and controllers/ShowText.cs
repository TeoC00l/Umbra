using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowText : MonoBehaviour
{
    [SerializeField] private Canvas introTextCanvas;
    private DialogueTrigger dt;
    [SerializeField] private Canvas dialogueCanvas;
    private bool triggerText = true;

    private void Awake()
    {
        dt = GetComponent<DialogueTrigger>();
        
    }

    private void Update()
    {
        if (triggerText)
        {
            StartCoroutine(WaitToShow());
            
            triggerText = false;
        }
        if (dt.dialogue.getPlayedStatus())
        {
            introTextCanvas.gameObject.SetActive(false);
        }
    }

    IEnumerator WaitToShow()
    {
        print("waiting");
        yield return new WaitForSeconds(3);
        dt.TriggerDialogue();
        print("done");
    }
}
