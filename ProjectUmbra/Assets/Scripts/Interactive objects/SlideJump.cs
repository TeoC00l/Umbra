using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideJump : MonoBehaviour
{

    private bool hasJumped = false;

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
            //other.GetComponent<Player>().Transition<PlayerSlidingState>();

            //DeathComponent.cachedPosition = other.transform.position;
            if(Input.GetKey(KeyCode.Space) && hasJumped == false)
            {

                hasJumped = true;
                //force = transform.forward.normalized + transform.up.normalized * 10;

                other.attachedRigidbody.velocity = Vector3.zero;
                other.attachedRigidbody.AddForce(new Vector3(0,10 , 10), ForceMode.VelocityChange);

                
            }
        }
    }
}
