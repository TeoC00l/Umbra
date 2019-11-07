using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class HingeBoard : MonoBehaviour
{
    [Tooltip("YOYOYO")]
    [SerializeField] private bool movingInZ;


    [SerializeField] private bool movingInX;

    private Transform playerTransform;
    private Transform cachedTrans;
    private NavMeshSurface navSurface;
    private Rigidbody rb;

    private void Start()
    {
        navSurface = GetComponent<NavMeshSurface>();
        cachedTrans = transform;
        InvokeRepeating("BakeMeshIfRotationIsChanged", 0, 2);
    }


    private void BakeMeshIfRotationIsChanged()
    {
     
            navSurface.BuildNavMesh();
            transform.hasChanged = false;
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerTransform = other.transform;
            rb = other.attachedRigidbody;
            if (movingInX)
            {
                //rb.constraints.
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (movingInZ)
            {
                
                other.transform.position = new Vector3(playerTransform.position.x , other.transform.position.y, other.transform.position.z);
            }
            else if(movingInX)
            {
                other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, playerTransform.position.z);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (movingInX)
            {
                other.attachedRigidbody.position = new Vector3(other.transform.position.x , other.transform.position.y, playerTransform.position.z);
            }
        }
    }
}
