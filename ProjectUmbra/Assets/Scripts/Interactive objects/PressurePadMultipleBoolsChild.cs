
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alice") || other.CompareTag("Set") || other.CompareTag("Grabbable"))
        {
            AudioManager.instance.Play("ButtonClick");
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
            AudioManager.instance.Play("ButtonClick");
            isPressed = false;
            isOccupied = false;
            feedbackLight.color = Color.red;
        }
    }
}
