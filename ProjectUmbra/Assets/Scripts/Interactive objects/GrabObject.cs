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
    [SerializeField] private LayerMask groundCheck;

    public void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    public void OnTriggerStay(Collider other)
    {
        if (!grabStatus && other.CompareTag("Grabbable") && Input.GetKeyDown(KeyCode.F))
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
        }else if (BoxGrounded() == false)
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
            direction = Vector3.forward;
        }

        if (playerMovement.cornerTurnerMode == 2)
        {
            direction = Vector3.left;
        }

        if (playerMovement.cornerTurnerMode == 3)
        {
            direction = Vector3.back;
        }
 
        RaycastHit hit;

        return (Physics.Raycast(player.transform.position, transform.TransformDirection(direction), out hit, 3f, layerMask));
    }




    public bool BoxGrounded()
    {
        if (Physics.BoxCast(box.transform.position, (box.GetComponent<BoxCollider>().transform.lossyScale + new Vector3(0.1f ,0.1f ,0.1f )) / 2, Vector3.down, Quaternion.identity, 0.5f, groundCheck))
        {
            Debug.Log("BoxGrounded");
            return true;

        }
        Debug.Log("not BoxGrounded");

        return false;
    }
}
