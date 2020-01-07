
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

        InvokeRepeating("IfNotOccupied", 0f, 2.5f);
    }

    private void IfNotOccupied()
    {
        if(isPressed == false)
        {
            isOccupied = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alice") || other.CompareTag("Set") || other.CompareTag("Grabbable"))
        {
            isPressed = true;
            isOccupied = true;
            feedbackLight.color = Color.green;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alice") || other.CompareTag("Set") || other.CompareTag("Grabbable"))
        {
            
            isPressed = false;
            isOccupied = false;
            feedbackLight.color = Color.red;
        }
    }
}
