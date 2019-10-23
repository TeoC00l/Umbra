using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody rb;
    private bool grabStatus;

    public void OnTriggerStay(Collider other)
    {
        if (!grabStatus && other.CompareTag("Grabbable") && Input.GetKeyDown(KeyCode.F))
        //if (other.CompareTag("Grabbable"))
        {
            Debug.Log("Grabbing");
            GameObject grabbableObject = other.gameObject;
            rb = grabbableObject.GetComponent<Rigidbody>();
            FixedJoint joint = player.AddComponent(typeof(FixedJoint)) as FixedJoint;
            joint.connectedBody = rb;
            grabStatus = true;
        }
    }

    public void Update()
    {
        if(grabStatus && Input.GetKeyUp(KeyCode.F))
        {
            Release();
        }
    }

    private void Release()
    {
        FixedJoint joint = player.GetComponent<FixedJoint>();
        Destroy(joint);
        grabStatus = false;
    }

    public bool GetGrabStatus()
    {
        return grabStatus;
    }
}
