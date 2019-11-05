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

    private bool isMovementLocked, isOnLadder, isJumping;

    [SerializeField] private float speed, topSpeed, jumpHeight, fallMultiplier, groundDistance;
    [SerializeField] private LayerMask Ground, layerMask;

    public CornerTurner cornerTurner;
    public Vector3 veloc;


    [SerializeField] private GameObject alice, set;

    //Methods
    void Start()
    {
        verticalLadderInput = Vector3.zero;
        horizontalLadderInput = Vector3.zero;
        rb = GetComponent<Rigidbody>();
        groundChecker = transform.GetChild(0);
        Physics.gravity = new Vector3(0, -15f, 0);
        Physics.IgnoreCollision(gameObject.GetComponent<BoxCollider>(), alice.GetComponent<BoxCollider>());
        Physics.IgnoreCollision(gameObject.GetComponent<BoxCollider>(), set.GetComponent<BoxCollider>());
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

    public void Move()
    {
        Vector3 newPosition = rb.position + transform.TransformDirection(input * speed * Time.fixedDeltaTime);
        rb.MovePosition(newPosition);
    }

    public void AutoMove(Vector3 input)
    {
           rb.velocity += rb.transform.forward * speed * Time.fixedDeltaTime;
    }

    public void MoveOnLadder()
    {      
        verticalLadderInput.y = Input.GetAxis("Vertical");
        horizontalLadderInput.z = Input.GetAxis("Horizontal");
        transform.Translate(verticalLadderInput * 5f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.isKinematic = false;
            //transform.Translate(Vector3.back * 35f * Time.deltaTime);
            rb.AddForce(Vector3.right * 5f, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.isKinematic = false;
            //transform.Translate(Vector3.forward * 35f * Time.deltaTime);
            rb.AddForce(Vector3.left * 5f, ForceMode.VelocityChange);
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
