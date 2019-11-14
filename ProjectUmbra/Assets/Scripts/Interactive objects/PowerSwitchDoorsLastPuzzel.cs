using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitchDoorsLastPuzzel : MonoBehaviour
{

    [SerializeField] private GameObject[] animGOs;
    [SerializeField] string animationBoolKey = "";
    [SerializeField] GameObject multipleBoolButtons;
    private Light buttonLight;

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
                multipleBoolButtons.GetComponent<PressurePadMultipleBools>().isActive = false;
                buttonLight.color = Color.green;

                foreach (GameObject animGo in animGOs)
                {
                    animGo.GetComponent<Animator>().SetBool(animationBoolKey, true);
                }

            }
        }
    }


}
