using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbLedge : MonoBehaviour
{
    [SerializeField] private Transform corner;
    [SerializeField]private Transform top;
    private bool velocityZeroApplied = false;


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.W))
            {
                if (velocityZeroApplied == false)
                {
                    other.attachedRigidbody.velocity = Vector3.zero;
                    velocityZeroApplied = true;
                }
                

                other.attachedRigidbody.velocity += Vector3.up* 20 * Time.fixedDeltaTime;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.attachedRigidbody.velocity = new Vector3(other.attachedRigidbody.velocity.x, 0, other.attachedRigidbody.velocity.z);
        }
    }
}
