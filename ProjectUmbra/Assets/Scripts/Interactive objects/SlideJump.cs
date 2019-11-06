using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideJump : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().Transition<PlayerSlidingState>();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DeathComponent.cachedPosition = other.transform.position;
            if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
            {
                //force = transform.forward.normalized + transform.up.normalized * 10;

                other.attachedRigidbody.velocity = Vector3.zero;
                other.attachedRigidbody.AddForce(new Vector3(0,10 , 10), ForceMode.VelocityChange);

                
            }
        }
    }
}
