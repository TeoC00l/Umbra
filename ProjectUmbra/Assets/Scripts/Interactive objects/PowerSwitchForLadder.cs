using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitchForLadder : MonoBehaviour
{

    [SerializeField] private GameObject[] animGOs;
    [SerializeField] string animationBoolKey = "";
    [SerializeField] string resetNameKey = "";

    //[SerializeField] private GameObject groundToActivate;
    private Light buttonLight;

    private bool played = false;
    private bool reset = false;

    private float cooldownToReset = 6;

    private void Start()
    {
        buttonLight = GetComponentInChildren<Light>();
        buttonLight.color = Color.yellow;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") )
        {
            if (Input.GetKey(KeyCode.F) && reset == false)
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
                    animGo.GetComponent<Animator>().SetBool(animationBoolKey, true);
                    //groundToActivate.GetComponent<BoxCollider>().isTrigger = false;

                }
                reset = true;     

                
            }
        }
    }

    private void FixedUpdate()
    {
        if(reset == true)
        {

            if(cooldownToReset >= 0)
            {
                cooldownToReset -= Time.fixedDeltaTime;
            }
            else
            {
                foreach(GameObject animGO in animGOs)
                {
                    animGO.GetComponent<Animator>().SetBool(animationBoolKey, false);
                    cooldownToReset = 6;
                }
                reset = false;
            }

        }
    }
}
