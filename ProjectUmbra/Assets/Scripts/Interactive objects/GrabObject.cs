using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private PlayerMovement playerMovement;
    [SerializeField] private LayerMask layerMask;
    private Rigidbody rb;
    private bool grabStatus;
    private GameObject box;
    private bool isPushing;

    public void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    public void OnTriggerStay(Collider other)
    {
        if (!grabStatus && other.CompareTag("Grabbable") && Input.GetKey(KeyCode.F))
        //if (other.CompareTag("Grabbable"))
        {
            box = other.gameObject;
            Debug.Log("Grabbing");
            GameObject grabbableObject = other.gameObject;
            rb = grabbableObject.GetComponent<Rigidbody>();
            FixedJoint joint = player.AddComponent(typeof(FixedJoint)) as FixedJoint;
            joint.connectedBody = rb;

            grabStatus = true;

            if (IsBoxInFront())
            {

            }
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


    public bool IsBoxInFront()
    {
        Vector3 direction = Vector3.zero;

        if (playerMovement.cornerTurnerMode == 0)
        {
            direction = Vector3.right;
        }

        if (playerMovement.cornerTurnerMode == 1)
        {
            direction = Vector3.back;
        }

        if (playerMovement.cornerTurnerMode == 2)
        {
            direction = Vector3.left;
        }

        if (playerMovement.cornerTurnerMode == 3)
        {
            direction = Vector3.forward;
        }
 
        RaycastHit hit;

        return (Physics.Raycast(player.transform.position, transform.TransformDirection(direction), out hit, 3f, layerMask));
    }
}
