//TODO: Göra metoder private

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    //Attributes
    private Vector3 input, verticalLadderInput, horizontalLadderInput;

    private Rigidbody rb;
    private Transform groundChecker;

    [SerializeField] private bool isMovementLocked, isOnLadder, isJumping;

    [SerializeField] private float speed, topSpeed, jumpHeight, fallMultiplier, groundDistance;
    [SerializeField] private LayerMask Ground, layerMask;

    public GameObject cornerTurner;
    public Vector3 veloc;


    [SerializeField] private GameObject alice, set;

    public RaycastHit SlideRayCastHit;
    [SerializeField] private LayerMask slideMask;

    public bool isUpdatingXPosition;
    Vector3 newPosition;

    [SerializeField] private Transform [] CornerTurners;
    [SerializeField] private Vector3 nextCornerTransform;
    private int corner = 0;
    private GameObject trans;
    //Methods
    void Start()
    {

        verticalLadderInput = Vector3.zero;
        horizontalLadderInput = Vector3.zero;
        rb = GetComponent<Rigidbody>();
        groundChecker = transform.GetChild(0);
        Physics.gravity = new Vector3(0, -15f, 0);
        //try { 
        Physics.IgnoreCollision(gameObject.GetComponent<CapsuleCollider>(), alice.GetComponent<BoxCollider>());
        Physics.IgnoreCollision(gameObject.GetComponent<CapsuleCollider>(), set.GetComponent<BoxCollider>());
        //} catch(UnassignedReferenceException)
        //{

        //}

        //GetNextCorner();


    }
    public void GetNextCorner()
    {
        //if (nextCornerTransform.gameObject.activeInHierarchy == false)
        //{
        //    corner += 1;
        //}
        nextCornerTransform = CornerTurners[corner].position;


        corner += 1;
        Debug.Log(CornerTurners.Length);
        Debug.Log(corner);
    }

    public void Move()
    {

        newPosition = rb.position + transform.TransformDirection(input * speed * Time.fixedDeltaTime);

        if (isUpdatingXPosition)
        {

            newPosition = new Vector3(nextCornerTransform.x, newPosition.y, newPosition.z);
        }
        else
        {
            newPosition = new Vector3(newPosition.x, newPosition.y, nextCornerTransform.z);
        }


        rb.MovePosition(newPosition);
    }








    private void FixedUpdate()
    {
        if (isJumping)
        {
            rb.velocity = Vector3.up * jumpHeight;
            isJumping = false;
        }

        ApplyAdditionalPhysics();

        if (Input.GetKeyDown(KeyCode.T))
        {
            set.GetComponent<NavMeshAgent>().Warp(gameObject.transform.position);
            alice.GetComponent<NavMeshAgent>().Warp(gameObject.transform.position);
        }

    }



    public void AutoMove(Vector3 input)
    {
        rb.velocity += rb.transform.forward * speed * Time.fixedDeltaTime;
    }

    public void MoveOnLadder()
    {
        verticalLadderInput.y = Input.GetAxis("Vertical");
        horizontalLadderInput.z = Input.GetAxis("Horizontal");
        transform.Translate(verticalLadderInput * 5 * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.isKinematic = false;
            ////transform.Translate(Vector3.back * 35f * Time.deltaTime);
            ///
            rb.AddForce(-transform.forward * 4f, ForceMode.VelocityChange);
            setLadderStatus(false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.isKinematic = false;
            ////transform.Translate(Vector3.forward * 35f * Time.deltaTime);
            rb.AddForce(transform.forward * 4f, ForceMode.VelocityChange);
            setLadderStatus(false);
        }
    }

    public void Jump()
    {
        isJumping = true;
    }

    public bool IsGrounded()
    {
        if (Physics.CheckSphere(groundChecker.position, groundDistance, Ground, QueryTriggerInteraction.Ignore))
        {
            return true;
        }
        return false;
    }

    public bool isSliding()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out SlideRayCastHit, 10f, slideMask))
        {
            return true;
        }
        return false;
    }

    private void ApplyAdditionalPhysics()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }

    //Getters and Setters
    public void SetInput()
    {
        input.z = Input.GetAxis("Horizontal");
    }
    public void setSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
    public void setLocked()
    {
        if (isMovementLocked)
        {
            isMovementLocked = false;
        }
        else
        {
            isMovementLocked = true;
        }
    }
    public void setVelocity(Vector3 velocity)
    {
        rb.velocity = velocity;
    }
    public bool getLocked()
    {
        return isMovementLocked;
    }
    public float getSpeed()
    {
        return speed;
    }
    public Vector3 getInput()
    {
        return input;
    }
    public bool getLadderStatus()
    {
        return isOnLadder;
    }
    public void setLadderStatus(bool status)
    {
        isOnLadder = status;
    }
}
