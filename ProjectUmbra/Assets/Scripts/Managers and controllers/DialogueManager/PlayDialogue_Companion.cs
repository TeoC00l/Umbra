using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDialogue_Companion : MonoBehaviour
{
    private DialogueTrigger dt;

    private void Start()
    {
        dt = GetComponent<DialogueTrigger>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Alice"))
        {
            dt.TriggerDialogue();
            gameObject.SetActive(false);
        }
    }
}
