using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitchDoorsLastPuzzel : MonoBehaviour
{

    [SerializeField] private GameObject[] animGOs;
    [SerializeField] private string animationBoolKey = "";
    [SerializeField] GameObject multipleBoolButtons;
    private Light buttonLight;

    private bool played = false;
    private bool isPressingF = false;

    private void Start()
    {
        buttonLight = GetComponentInChildren<Light>();
        buttonLight.color = Color.yellow;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isPressingF == true)
            {
                //Animation leverAnimation = GetComponentInChildren<Animation>();
                //if (!played)
                //{
                //    leverAnimation.Play();
                //    AudioManager.instance.Play("LeverPull");
                //    played = true;
                //}
                if (multipleBoolButtons != null)
                {
                    multipleBoolButtons.GetComponent<PressurePadMultipleBools>().isActive = false;

                }

                foreach (GameObject animGo in animGOs)
                {
                    
                    Animator leverAnimator = GetComponentInChildren<Animator>();
                    Animator goAnim = animGo.GetComponent<Animator>();

                    if (leverAnimator.GetBool(animationBoolKey) == false)
                    {
                        leverAnimator.SetBool(animationBoolKey, true);
                        AudioManager.instance.Play("LeverPull");
                        buttonLight.color = Color.green;

                    }
                    if (goAnim.GetBool(animationBoolKey) == false)
                    {
                        goAnim.SetBool(animationBoolKey, true);

                    }

                }



            }
        }
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isPressingF = true;
        }


        if (Input.GetKeyUp(KeyCode.F))
        {
            isPressingF = false;
        }
    }


}
