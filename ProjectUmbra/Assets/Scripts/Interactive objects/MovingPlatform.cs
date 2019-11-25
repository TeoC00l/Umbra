using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private BoxCollider platformCollider;
    private GameObject player;
    private bool isExitMode;

    private void Start()
    {
        platformCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!isExitMode)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    player.transform.SetParent(transform);
                }
            }
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
            player = other.gameObject;
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
            other.gameObject.transform.SetParent(null);
        }


        if (other.CompareTag("PlatformTrigger"))
        {
            isExitMode = false;
        }
    }
}
