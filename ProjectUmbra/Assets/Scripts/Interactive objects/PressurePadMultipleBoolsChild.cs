
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadMultipleBoolsChild : MonoBehaviour
{
    public bool isPressed = false;
    public bool isOccupied = false;

    private Light feedbackLight;

    private void Start()
    {
        feedbackLight = GetComponentInChildren<Light>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alice") || other.CompareTag("Set") || other.CompareTag("Box"))
        {
            isPressed = true;
            feedbackLight.color = Color.green;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alice") || other.CompareTag("Set") || other.CompareTag("Box"))
        {
            isPressed = false;
            feedbackLight.color = Color.red;
        }
    }
}
