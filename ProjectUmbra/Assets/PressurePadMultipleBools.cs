using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadMultipleBools : MonoBehaviour
{
    private Animator anim;
    private bool isPressed = false;
    [SerializeField] GameObject animGO;
    [SerializeField] string animationBoolKey = "";
    [SerializeField] GameObject[] PressurePads;
    private int allBools;

    // Start is called before the first frame update
    void Start()
    {
        anim = animGO.GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        allBools = 0;
        foreach (GameObject pressurePad in PressurePads)
        {
            

            if(pressurePad.GetComponent<PressurePadMultipleBoolsChild>().isPressed == true)
            {
                allBools++;
            }
            

        }

        if(allBools >= (PressurePads.Length -1))
        {
            anim.SetBool(animationBoolKey, true);
        }
        else
        {
            anim.SetBool(animationBoolKey, false);
        }

    }







}
