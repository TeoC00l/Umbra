using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 input = Vector3.zero;
    private Vector3 verticalInput = Vector3.zero;
    private Vector3 horizontalLadderInput = Vector3.zero;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float topSpeed = 10f;
    [SerializeField] private float JumpHeight = 2f;
    [SerializeField] private float GroundDistance = 0.2f;

    public LayerMask Ground;
    private Rigidbody rb;
    private Transform groundChecker;
    public CornerTurner cornerTurner;

    [SerializeField] Transform wallCheckerRight;
    [SerializeField] Transform wallCheckerLeft;

    [SerializeField] private LayerMask layerMask;

    private bool movementIsLocked = false;
    private bool isOnLadder = false;

    public Vector3 veloc;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundChecker = transform.GetChild(0);
        Physics.gravity = new Vector3(0, -15f, 0);
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        veloc = rb.velocity;
    }



    public void SetInput()
    {
        input.z = Input.GetAxis("Horizontal");
    }

    public void Move()
    {

        Vector3 newPosition = rb.position + transform.TransformDirection(input * speed * Time.fixedDeltaTime);
        rb.MovePosition(newPosition);

        //old input method

        //if (input.z > 0)
        //{
        //    if (rb.velocity.magnitude < topSpeed)
        //    {
        //        rb.velocity += rb.transform.forward * speed * Time.fixedDeltaTime;

        //    }
        //}
        //if (input.z < 0)
        //{
        //    if (rb.velocity.magnitude < topSpeed)
        //    {
        //        rb.velocity -= rb.transform.forward * speed * Time.fixedDeltaTime;

        //    }
        //}
    }

    public void AutoMove(Vector3 input)
    {
           rb.velocity += rb.transform.forward * speed * Time.fixedDeltaTime;
    }

    public void MoveOnLadder()
    {
        
        verticalInput.y = Input.GetAxis("Vertical");
        horizontalLadderInput.z = Input.GetAxis("Horizontal");
        transform.Translate(verticalInput * 5f * Time.deltaTime);
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
        rb.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
    
    }

    public bool isGrounded()
    {
        if (Physics.CheckSphere(groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore))
        {
            return true;
        }
        return false;

    }

    public void setSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public float getSpeed()
    {
        return speed;
    }

    public Vector3 getInput()
    {
        return input;
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
    public bool getLocked()
    {
        return movementIsLocked;
    }

    public void setVelocity(Vector3 velocity)
    {
        rb.velocity = velocity;
    }


    private bool CheckForWall(Transform wallChecker)
    {
        if(Physics.CheckSphere(wallChecker.position, 0.25f, layerMask, QueryTriggerInteraction.Ignore))
        {
            return true;
        }

        return false;
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
