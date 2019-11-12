
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadMultipleBoolsChild : MonoBehaviour
{
    public bool isPressed = false;
    public bool isOccupied = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alice") || other.CompareTag("Set") || other.CompareTag("Grabbable"))
        {
            isPressed = true;
            
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alice") || other.CompareTag("Set"))
        {
            isPressed = false;
        }
    }
}
