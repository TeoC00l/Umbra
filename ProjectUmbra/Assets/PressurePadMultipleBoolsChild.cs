using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadMultipleBoolsChild : MonoBehaviour
{
    public bool isPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alice") || other.CompareTag("Set"))
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
