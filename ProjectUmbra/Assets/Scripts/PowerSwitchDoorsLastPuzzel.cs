using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitchDoorsLastPuzzel : MonoBehaviour
{

    [SerializeField] private GameObject[] animGOs;
    [SerializeField] string animationBoolKey = "";
    [SerializeField] GameObject multipleBoolButtons;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                multipleBoolButtons.GetComponent<PressurePadMultipleBools>().isActive = false;

                foreach (GameObject animGo in animGOs)
                {
                    animGo.GetComponent<Animator>().SetBool(animationBoolKey, true);
                }
            }
        }
    }


}
