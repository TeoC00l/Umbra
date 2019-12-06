using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitchForLadder : MonoBehaviour
{

    [SerializeField] private GameObject[] animGOs;
    [SerializeField] string animationBoolKey = "";
    [SerializeField] private bool hasCoolDownToReset;
    [SerializeField] private float coolDownToReset;
    private float coolDown;

    //[SerializeField] private GameObject groundToActivate;
    private Light buttonLight;

    private bool played = false;
    private bool isPressingF = false;

    private void Awake()
    {
        buttonLight = GetComponentInChildren<Light>();
        buttonLight.color = Color.yellow;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                //if (!played)
                //{
                //    Animation leverAnimation = GetComponentInChildren<Animation>();
                //    leverAnimation.Play();
                //    played = true;
                //}
                foreach (GameObject animGo in animGOs)
                {
                    Animator animator = animGo.GetComponent<Animator>();
                    Animator leverAnimator = GetComponentInChildren<Animator>();

                    if ((animator.GetBool(animationBoolKey)) == false)
                    {
                        animator.SetBool(animationBoolKey, true);
                        leverAnimator.SetBool(animationBoolKey, true);
                        AudioManager.instance.Play("LeverPull");
                        buttonLight.color = Color.green;

                    }
                    else
                    {
                        animator.SetBool(animationBoolKey, false);
                        leverAnimator.SetBool(animationBoolKey, false);
                        AudioManager.instance.Play("LeverPull");
                        buttonLight.color = Color.yellow;

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


        if (hasCoolDownToReset == true)
        {

            if (coolDown >= 0)
            {
                coolDown -= Time.fixedDeltaTime;
            }
            else
            {
                foreach (GameObject animGO in animGOs)
                {
                    animGO.GetComponent<Animator>().SetBool(animationBoolKey, false);
                    coolDown = coolDownToReset;
                    buttonLight.color = Color.yellow;

                }
            }

        }
    }
}
