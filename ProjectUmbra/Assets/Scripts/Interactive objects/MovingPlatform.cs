using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private BoxCollider platformCollider;


    private void Start()
    {
        platformCollider = GetComponent<BoxCollider>();
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

    //    private void OnTriggerEnter(Collider other)
    //    {
    //        if (other.CompareTag("Player"))
    //        {
    //            other.gameObject.transform.SetParent(transform.parent);
    //        }
    //    }

    //    private void OnTriggerExit(Collider other)
    //    {
    //        if (other.CompareTag("Player"))
    //        {
    //            other.gameObject.transform.SetParent(null);
    //        }
    //    }
}
