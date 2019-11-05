using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideJump : MonoBehaviour
{

    Vector3 force;
    private void Start()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space))
            {
                force = transform.forward.normalized + transform.up.normalized * 10;
                
                other.attachedRigidbody.AddForce(force);
            }
        }
    }
}
