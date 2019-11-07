using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadToActivateButton : MonoBehaviour
{
    [SerializeField] private GameObject animGO;
    [SerializeField] private string animationBoolKey = "";

    [SerializeField]  private GameObject[] pressurePads;
    [SerializeField] private int numbersOfActiveBools;

    [SerializeField] private Light buttonLight;

    private int allBools;
    private bool buttonCanBePressed = false;
    private Animation animation;
    
    private void Start()
    {
        buttonLight = GetComponentInChildren<Light>();
        animation = animGO.GetComponent<Animation>();
        buttonLight.intensity = 0;
         
    }


    private void FixedUpdate()
    {
        allBools = 0;
        foreach (GameObject pressurePad in pressurePads)
        {
            if (pressurePad.GetComponent<PressurePadMultipleBoolsChild>().isPressed == true)
            {
                allBools++;
            }
        }

        if (allBools >= numbersOfActiveBools)
        {
            buttonLight.intensity = 5;
            buttonCanBePressed = true;


        }
        else
        {
            buttonLight.intensity = 0;
            buttonCanBePressed = false;

        }



    }

    private void OnTriggerStay(Collider other)
    {

        if (buttonCanBePressed)
        {
            if (other.CompareTag("Player"))
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    animation.Play("MovingPlatformGroup2Level2");
                }
                
            }
        }
    }



}
