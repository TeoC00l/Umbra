using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTrigger : MonoBehaviour
{
    private Animator anim;
    private bool isPressed = false;
    [SerializeField] GameObject animGO;
    [SerializeField] string animationBoolKey = "";

    
    void Start()
    {
        anim = animGO.GetComponent<Animator>();
    }

    //Byt ut "ObjectToAnimate" mot objektet som ska animeras, samt animator controllers och animationer i dem.
    //Skriv villkorsboolens namn i animationBoolKey.
    

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (!isPressed)
                {
                    anim.SetBool(animationBoolKey, true);
                    
                    isPressed = true;
                    
                }

                else if (isPressed)
                {
                    anim.SetBool(animationBoolKey, false);
                    isPressed = false;
                    
                }

            }
        }
    }
}
