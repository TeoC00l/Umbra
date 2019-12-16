using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDialogue_DoNotDeactivate : MonoBehaviour
{

    private DialogueTrigger dt;

    private void Start()
    {
        dt = GetComponent<DialogueTrigger>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dt.TriggerDialogue();
            //gameObject.SetActive(false);
        }
    }
}

