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


    private void Start()
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
                buttonLight.color = Color.green;
                if (!played)
                {
                    Animation leverAnimation = GetComponentInChildren<Animation>();
                    leverAnimation.Play();
                    played = true;
                }
                foreach (GameObject animGo in animGOs)
                {
                    Animator animator = animGo.GetComponent<Animator>();
                    if ((animator.GetBool(animationBoolKey)) == false)
                    {
                        animator.SetBool(animationBoolKey, true);
                    }
                    else
                    {
                        animator.SetBool(animationBoolKey, false);
                    }


                }


            }
        }
    }

    private void FixedUpdate()
    {
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
                }
            }

        }
    }
}
