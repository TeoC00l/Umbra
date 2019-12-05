using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadTrigger : MonoBehaviour
{
    private Animator anim;
    private bool isPressed = false;
    [SerializeField] GameObject animGO;
    [SerializeField] string animationBoolKey = "";
    public bool isOccupied = false;
    //private BoxCollider boxCollider;
    //[SerializeField] private LayerMask TriggerLayerMask;

    private Light feedbackLight;
    void Start()
    {
        anim = animGO.GetComponent<Animator>();
        feedbackLight = GetComponentInChildren<Light>();


    }






    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alice") || other.CompareTag("Set") || other.CompareTag("Grabbable"))
        {
            isPressed = true;
            isOccupied = true;
            feedbackLight.color = Color.green;

            anim.SetBool(animationBoolKey, true);
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alice") || other.CompareTag("Set") || other.CompareTag("Grabbable"))
        {

            isPressed = false;
            isOccupied = false;
            feedbackLight.color = Color.red;
            anim.SetBool(animationBoolKey, false);

        }
    }

    //private void FixedUpdate()
    //{
    //    if (BoxCheck())
    //    {
    //        if (!isPressed)
    //        {
    //            anim.SetBool(animationBoolKey, true);

    //            isPressed = true;

    //        }
    //    }
    //    else
    //    {
    //        if (isPressed)
    //        {
    //            anim.SetBool(animationBoolKey, false);

    //            isPressed = false;

    //        }
    //    }
    //}

    //private bool BoxCheck()
    //{
    //    if (Physics.CheckBox(transform.position, boxCollider.size / 2, Quaternion.identity, TriggerLayerMask))
    //    {

    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}



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
