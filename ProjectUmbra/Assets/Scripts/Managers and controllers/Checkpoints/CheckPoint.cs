using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    [SerializeField] private CheckPointManager checkpointManager;
    private bool triggered = false;
    private Quaternion playerRotationOnEntry;
   
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            playerRotationOnEntry = other.gameObject.transform.rotation;
            checkpointManager.UpdateCurrentCheckpoint(transform, playerRotationOnEntry);
            triggered = true;
        }
    }
}
