using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private BoxCollider platformCollider;
    private int framesPassed;
    private GameObject player;
    private bool isExitMode;

    private void Start()
    {
        platformCollider = GetComponent<BoxCollider>();
        framesPassed = 0;
    }

    private void Update()
    {

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    player.gameObject.transform.SetParent(transform);
        //}

    }

    //    private void OnCollisionEnter(Collision collision)
    //    {
    //        if (collision.gameObject.CompareTag("Player"))
    //        {
    //            collision.gameObject.transform.SetParent(transform);
    //        }
    //    }

    //    private void OnCollisionExit(Collision collision)
    //    {
    //        if (collision.gameObject.CompareTag("Player"))
    //        {
    //            collision.gameObject.transform.SetParent(transform);
    //        }
    //    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!isExitMode)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    player.transform.SetParent(transform);
                }
            }

            //if(player.GetComponent<PlayerMovement>().IsGrounded() == true)
            //{
            //    player.transform.SetParent(null);
            //}

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        player.transform.SetParent(null);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("entered");
            //gameObject.GetComponent<Animation>().animatePhysics = true;
            framesPassed = 0;

            player = other.gameObject;

            //player.gameObject.transform.SetParent(transform);

            //InvokeRepeating("AddCounter", 0.1f, Time.deltaTime);
        }

        if (other.CompareTag("PlatformTrigger"))
        {
            isExitMode = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //other.gameObject.transform.SetParent(transform);

            other.gameObject.transform.SetParent(null);
            //framesPassed = 0;

        }


        if (other.CompareTag("PlatformTrigger"))
        {
            isExitMode = false;
        }
    }

    private void AddCounter()
    {
        Debug.Log("gogogo");
        framesPassed++;
    }
}
