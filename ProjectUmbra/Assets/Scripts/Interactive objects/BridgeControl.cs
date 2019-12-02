using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class BridgeControl : MonoBehaviour
{


    [SerializeField] private NavMeshSurface navMeshSurface;
    //[SerializeField] private NavMeshLink navLink;

    private Quaternion originalAngles;
    private Rigidbody rb;
    private bool tipped = false;
    //[SerializeField] private Quaternion finalRotation;
    [SerializeField] Vector3 tippingDirection;


    private void Start()
    {

        originalAngles = transform.localRotation;
        rb = GetComponent<Rigidbody>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.collider.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.AddForce(tippingDirection, ForceMode.Force);
        }
        if (collision.gameObject.CompareTag("Stopper"))
        {
            Destroy(this.GetComponent<HingeJoint>());

            rb.constraints = RigidbodyConstraints.FreezeAll;
            rb.isKinematic = true;
            //gameObject.transform.rotation = Quaternion.Euler(finalRotation.x, finalRotation.y, finalRotation.z);


            //navMeshSurface.BuildNavMesh();
        }
    }

    private void Update()
    {
        
        //if(transform.localEulerAngles.z < 0f)
        //{
        //    transform.localRotation = originalAngles;
        //}
        //if (transform.localEulerAngles.z > 359f)
        //{
            
        //    tipped = true;
        //}
        //if(tipped && transform.localEulerAngles.z > 359/*rb.velocity == Vector3.zero*/)
        //{
        //    Destroy(this.GetComponent<HingeJoint>());

        //    rb.constraints = RigidbodyConstraints.FreezeAll;
        //    rb.isKinematic = true;
        //    gameObject.transform.rotation = Quaternion.Euler(finalRotation.x, finalRotation.y, finalRotation.z);
            

        //    //navMeshSurface.BuildNavMesh();
            
            
        //}
       
    }


    
}
