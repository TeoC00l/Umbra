using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 input = Vector3.zero;
    private float speed = 75f;
    [SerializeField] private float JumpHeight = 2f;
    [SerializeField] private float DashDistance = 5f;
    [SerializeField] private float GroundDistance = 0.2f;
    public LayerMask Ground;
    private Rigidbody rb;
    private Transform groundChecker;
    public CornerTurner cornerTurner;
    [SerializeField] Transform wallCheckerRight;
    [SerializeField] Transform wallCheckerLeft;

    [SerializeField] private LayerMask layerMask;


    private bool movementIsLocked = false;


    public Vector3 veloc;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundChecker = transform.GetChild(0);
        Physics.gravity = new Vector3(0, -15f, 0);
        Debug.Log(Physics.gravity);


    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        SetInput();
        veloc = rb.velocity;


    }



    public void SetInput()
    {
        input.z = Input.GetAxis("Horizontal");
    }

    public void Move()
    {
        //if (rb.velocity.magnitude < 10)
        //{
        //    rb.velocity += input  * speed * Time.fixedDeltaTime;
        //}


        if (input.z >0)
        {
            if (rb.velocity.magnitude < 10)
            {
                rb.velocity += rb.transform.forward * speed * Time.fixedDeltaTime;

            }
        }
        if (input.z < 0)
        {
            if (rb.velocity.magnitude < 10)
            {
                rb.velocity -= rb.transform.forward * speed * Time.fixedDeltaTime;

            }
        }
        //body.AddForce(input * Speed * Time.fixedDeltaTime, ForceMode.Acceleration);        
    }

    public void AutoMove(Vector3 input)
    {
           rb.velocity += rb.transform.forward * speed * Time.fixedDeltaTime;
    }
        //if(input.z == 1)
        //{
        //    if (rb.velocity.magnitude < 10)
        //    {
        //        rb.velocity += rb.transform.forward * speed * Time.fixedDeltaTime;

        //    }
        //}
        //if (input.z == -1)
        //{
        //    if (rb.velocity.magnitude < 10)
        //    {
        //        rb.velocity -= rb.transform.forward * speed * Time.fixedDeltaTime;

        //    }
        //}

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
        Debug.Log(newSpeed);
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


    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Corner"))
    //    {
    //        cornerTurner = other.gameObject.GetComponent<CornerTurner>();
    //    }
    //}

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


}
