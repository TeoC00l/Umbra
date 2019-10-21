using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderControl : MonoBehaviour
{
    private PlayerMovement pm;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) { 
            pm = other.GetComponent<PlayerMovement>();
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.W) && !pm.getLadderStatus())
        {
            pm.setLadderStatus(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && pm.getLadderStatus())
        {
            pm.setLadderStatus(false);
        }
    }
}
