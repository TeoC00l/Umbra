using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadTrigger : MonoBehaviour
{
    private Animator anim;
    private bool isPressed = false;
    [SerializeField] GameObject animGO;
    [SerializeField] string animationBoolKey = "";
    private BoxCollider boxCollider;
    [SerializeField] private LayerMask TriggerLayerMask;
    void Start()
    {
        anim = animGO.GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider>();

    }

    //Byt ut "ObjectToAnimate" mot objektet som ska animeras, samt animator controllers och animationer i dem.
    //Skriv villkorsboolens namn i animationBoolKey.


    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Player") || other.CompareTag("Set") || other.CompareTag("Alice"))
    //    {

    //        if (!isPressed)
    //        {
    //            anim.SetBool(animationBoolKey, true);

    //            isPressed = true;

    //        }




    //    }

    //}

    private void FixedUpdate()
    {
        if (BoxCheck())
        {
            if (!isPressed)
            {
                anim.SetBool(animationBoolKey, true);

                isPressed = true;

            }
        }
        else
        {
            if (isPressed)
            {
                anim.SetBool(animationBoolKey, false);

                isPressed = false;

            }
        }
    }

    private bool BoxCheck()
    {
        if (Physics.CheckBox(transform.position, boxCollider.size / 2, Quaternion.identity, TriggerLayerMask))
        {

            return true;
        }
        else
        {
            return false;
        }
    }



    //private void OnTriggerExit(Collider other)
    //{

    //    if (other.CompareTag("Player") || other.CompareTag("Set") || other.CompareTag("Alice"))
    //    {
    //        if (isPressed)
    //        {
    //            anim.SetBool(animationBoolKey, false);
    //            isPressed = false;

    //        }
    //    }

    //}

}
