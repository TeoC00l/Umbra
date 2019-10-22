//TODO: Göra metoder private

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //Attributes
    private Vector3 input;
    private Vector3 verticalLadderInput;
    private Vector3 horizontalLadderInput;
    private Rigidbody rb;
    private Transform groundChecker;
    private bool movementIsLocked = false;
    private bool isOnLadder = false;

    [SerializeField] private float speed;
    [SerializeField] private float topSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float groundDistance;
    [SerializeField] private LayerMask Ground;
    [SerializeField] private LayerMask layerMask;

    public CornerTurner cornerTurner;
    public Vector3 veloc;


    //Methods
    void Start()
    {
        verticalLadderInput = Vector3.zero;
        horizontalLadderInput = Vector3.zero;
        rb = GetComponent<Rigidbody>();
        groundChecker = transform.GetChild(0);
        Physics.gravity = new Vector3(0, -15f, 0);
    }

    void Update()
    {
        veloc = rb.velocity;
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
        if(horizontalLadderInput.z < 0)
        {
            rb.isKinematic = false;
            rb.AddForce(Vector3.back * 5f);
        }
        if (horizontalLadderInput.z > 0)
        {
            rb.isKinematic = false;
            rb.AddForce(Vector3.forward * 5f);
        }

    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);   
    }

    public bool IsGrounded()
    {
        if (Physics.CheckSphere(groundChecker.position, groundDistance, Ground, QueryTriggerInteraction.Ignore))
        {
            return true;
        }
        return false;
    }

    //Används inte -Ta bort? /Teo
    private bool CheckForWall(Transform wallChecker)
    {
        if (Physics.CheckSphere(wallChecker.position, 0.25f, layerMask, QueryTriggerInteraction.Ignore))
        {
            return true;
        }
        return false;
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
        if (movementIsLocked)
        {
            movementIsLocked = false;
        }
        else
        {
            movementIsLocked = true;
        }
    }
    public void setVelocity(Vector3 velocity)
    {
        rb.velocity = velocity;
    }
    public bool getLocked()
    {
        return movementIsLocked;
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
