using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody rb;
    private bool grabStatus;
    private GameObject box;
    public void OnTriggerStay(Collider other)
    {
        if (!grabStatus && other.CompareTag("Grabbable") && Input.GetKeyDown(KeyCode.F))
        //if (other.CompareTag("Grabbable"))
        {
            box = other.gameObject;
            Debug.Log("Grabbing");
            GameObject grabbableObject = other.gameObject;
            rb = grabbableObject.GetComponent<Rigidbody>();
            //other.transform.SetParent(player.transform);
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
        //box.transform.SetParent(null);


    }

    public bool GetGrabStatus()
    {
        return grabStatus;
    }
}
