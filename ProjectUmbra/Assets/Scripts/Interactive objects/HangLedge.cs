using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangLedge : MonoBehaviour
{

    private bool velocityZeroApplied = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.attachedRigidbody.velocity = Vector3.zero;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.W))
            {

                other.attachedRigidbody.velocity = new Vector3(0, other.attachedRigidbody.velocity.y, 0);



                other.attachedRigidbody.velocity += Vector3.up * 20 * Time.fixedDeltaTime;
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.attachedRigidbody.velocity = Vector3.zero;
        }
    }
}
