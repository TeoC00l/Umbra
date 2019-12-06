using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayKarmaDependentDialogue : MonoBehaviour
{
    private KarmaDependentDialogueTrigger dt;

    private void Start()
    {
        dt = GetComponent<KarmaDependentDialogueTrigger>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dt.TriggerDialogue();
            gameObject.SetActive(false);
        }
    }
}
