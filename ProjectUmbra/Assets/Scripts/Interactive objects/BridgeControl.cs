using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeControl : MonoBehaviour
{
    private Quaternion originalAngles;
    private Rigidbody rb;
    private bool tipped = false;
    [SerializeField] private Quaternion finalRotation;

    
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
        if (transform.localEulerAngles.z > 89f)
        {
            
            tipped = true;
        }
        if(tipped && rb.velocity == Vector3.zero)
        {
            gameObject.transform.rotation = Quaternion.Euler(finalRotation.x, finalRotation.y, finalRotation.z);

            rb.constraints = RigidbodyConstraints.FreezeAll;
            Destroy(this.GetComponent<HingeJoint>());
        }
       
    }
}
