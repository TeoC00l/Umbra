using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitchForLadder : MonoBehaviour
{

    [SerializeField] private GameObject[] animGOs;
    [SerializeField] string animationBoolKey = "";
    [SerializeField] private GameObject groundToActivate;
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
            if (Input.GetKey(KeyCode.F))
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
                    groundToActivate.GetComponent<BoxCollider>().isTrigger = false;
                }
            }
        }
    }


}
