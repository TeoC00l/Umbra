using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitchForLadder : MonoBehaviour
{

    [SerializeField] private GameObject[] animGOs;
    [SerializeField] string animationBoolKey = "";
    //[SerializeField] private bool hasCoolDownToReset;
    //[SerializeField] private float coolDownToReset;
    //private float coolDown;

    //[SerializeField] private GameObject groundToActivate;
    private Light buttonLight;

    private bool played = false;
    private bool isPressingF;

    private void Awake()
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
                //if (!played)
                //{
                //    Animation leverAnimation = GetComponentInChildren<Animation>();
                //    leverAnimation.Play();
                //    played = true;
                //}

                Debug.Log(animGOs.Length);
                foreach (GameObject animGo in animGOs)
                {
                    Animator animator = animGo.GetComponent<Animator>();
                    Animator leverAnimator = GetComponentInChildren<Animator>();
                    Debug.Log(animator.GetBool(animationBoolKey));

                    if ((animator.GetBool(animationBoolKey)) == true)
                    {
                        animator.SetBool(animationBoolKey, false);
                        leverAnimator.SetBool(animationBoolKey, false);
                        AudioManager.instance.Play("LeverPull");
                        buttonLight.color = Color.yellow;
                        break;
                    }else
                    {
                        animator.SetBool(animationBoolKey, true);
                        leverAnimator.SetBool(animationBoolKey, true);
                        AudioManager.instance.Play("LeverPull");
                        buttonLight.color = Color.green;
                        break;
                        return;
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
        else
        {
            isPressingF = false;
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            isPressingF = false;
        }


        //if (hasCoolDownToReset == true)
        //{

        //    if (coolDown >= 0)
        //    {
        //        coolDown -= Time.fixedDeltaTime;
        //    }
        //    else
        //    {
        //        foreach (GameObject animGO in animGOs)
        //        {
        //            animGO.GetComponent<Animator>().SetBool(animationBoolKey, false);
        //            coolDown = coolDownToReset;
        //            buttonLight.color = Color.yellow;

        //        }
        //    }

        //}
    }
}
