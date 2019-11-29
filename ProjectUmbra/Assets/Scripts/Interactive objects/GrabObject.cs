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
    private Rigidbody boxRB;
    private bool isPushing;
    [SerializeField] private LayerMask groundCheck;
    RaycastHit hit;
    
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
            boxRB = other.attachedRigidbody;
            FreezeRotation();
            Debug.Log("Grabbing");
            GameObject grabbableObject = other.gameObject;
            //rb = grabbableObject.GetComponent<Rigidbody>();
            rb = player.GetComponent<Rigidbody>();
            FixedJoint joint = box.AddComponent(typeof(FixedJoint)) as FixedJoint;

            joint.connectedBody = rb;
            //joint.anchor = player.transform.position;
            //joint.connectedAnchor = transform.position;
            ////box.GetComponent<Rigidbody>().velocity = Vector3.zero;
            grabStatus = true;
        }
    }

    private void FreezeRotation()
    {
        if (boxRB.constraints == RigidbodyConstraints.FreezePositionX)
        {
            boxRB.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionX;
        }
        else
        {
            boxRB.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
        }
    }

    public void Update()
    {
        if (grabStatus && Input.GetKeyUp(KeyCode.F))
        {
            Release();
        }
        else if (grabStatus && BoxGroundedRaycast() == false || player.GetComponent<PlayerMovement>().IsGrounded() == false)
        {
            Release();
        }
    }


    private void Release()
    {
        FixedJoint joint = box.GetComponent<FixedJoint>();
        Destroy(joint);
        grabStatus = false;
        
        if(boxRB.constraints == RigidbodyConstraints.FreezePositionX)
        {
            UnFreezeZAxis();

        }
        else
        {
            UnFreezeXAxis();


        }

        Debug.Log("RElease");
        //box.transform.SetParent(null);


    }
    private void UnFreezeZAxis()
    {

        //boxRB.constraints = RigidbodyConstraints.FreezeRotationX;
        boxRB.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX;
    }

    private void UnFreezeXAxis()
    {
        //boxRB.constraints = RigidbodyConstraints.FreezeRotationZ;
        boxRB.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionZ;
    }

    public bool GetGrabStatus()
    {
        return grabStatus;
    }
    


    public bool BoxGroundedRaycast()
    {
        
        if (Physics.Raycast(box.transform.position,Vector3.down, 1f,groundCheck ,QueryTriggerInteraction.Ignore)){
            return true;

        }
        return false;
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



    //[SerializeField] private GameObject player;
    //private PlayerMovement playerMovement;
    //[SerializeField] private LayerMask layerMask;

    //private Rigidbody rb;
    //private bool grabStatus;
    //private GameObject box;
    //private bool isPushing;
    //[SerializeField] private LayerMask groundCheck;

    //public void Start()
    //{
    //    playerMovement = player.GetComponent<PlayerMovement>();
    //}

    //public void OnTriggerStay(Collider other)
    //{
    //    if (!grabStatus && other.CompareTag("Grabbable") && Input.GetKeyDown(KeyCode.F))
    //    //if (other.CompareTag("Grabbable"))
    //    {
    //        box = other.gameObject;
    //        Debug.Log("Grabbing");
    //        GameObject grabbableObject = other.gameObject;
    //        rb = player.GetComponent<Rigidbody>();
    //        //rb = grabbableObject.GetComponent<Rigidbody>();
    //        //grabbableObject.GetComponent<BoxCollider>().material = 
    //        //grabbableObject.GetComponent<PhysicMaterial>().dynamicFriction = 0;


    //        SpringJoint joint = box.AddComponent(typeof(SpringJoint)) as SpringJoint;
    //        joint.connectedBody = rb;
    //        joint.enableCollision = true;
    //        joint.minDistance = 0.9f;
    //        joint.maxDistance = 0.9f;
    //        joint.spring = 1000;
    //        joint.damper = 100;
    //        grabStatus = true;
    //    }
    //}

    //public void Update()
    //{
    //    if (grabStatus && Input.GetKeyUp(KeyCode.F))
    //    {
    //        Release();
    //    }
    //    //else if (grabStatus && BoxGrounded() == false || player.GetComponent<PlayerMovement>().IsGrounded() == false)
    //    //{
    //    //    Release();
    //    //}
    //}

    //private void Release()
    //{
    //    SpringJoint joint = box.GetComponent<SpringJoint>();
    //    Destroy(joint);
    //    grabStatus = false;
    //    //box.transform.SetParent(null);


    //}


}
