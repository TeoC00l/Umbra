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
    //private Color buttonLightColor = Color.yellow;

    private int allBools;
    private bool buttonCanBePressed = false;
    private Animation gameobject_animation;
    private Animator gameobject_animator;

    private void Start()
    {
        buttonLight = GetComponentInChildren<Light>();
        gameobject_animation = animGO.GetComponent<Animation>();
        gameobject_animator = animGO.GetComponent<Animator>();
        //buttonLight.color = Color.red;

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
            buttonLight.color = Color.yellow;
            buttonCanBePressed = true;


        }
        else
        {
            buttonLight.color = Color.red;
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
                    buttonLight.color = Color.green;
                    gameobject_animation.Play();
                    gameobject_animator.SetBool("Active", true);
                }
                
            }
        }
    }



}
