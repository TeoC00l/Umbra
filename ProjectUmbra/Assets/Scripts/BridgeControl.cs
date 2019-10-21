using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeControl : MonoBehaviour
{
    private Quaternion originalAngles;
    private Rigidbody rb;
    private bool tipped = false;

    private void Start()
    {

        originalAngles = transform.localRotation;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        if(transform.localEulerAngles.z < 0f)
        {
            transform.localRotation = originalAngles;
        }
        if (transform.localEulerAngles.z > 80f)
        {
            Destroy(this.GetComponent<HingeJoint>());
            tipped = true;
        }
        if(tipped && rb.velocity == Vector3.zero)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
       
    }
}
