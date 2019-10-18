using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 input = Vector3.zero;
    private float Speed = 5f;
    [SerializeField] private float JumpHeight = 2f;
    [SerializeField] private float DashDistance = 5f;
    [SerializeField] private float GroundDistance = 0.2f;
    public LayerMask Ground;
    private Rigidbody body;
    private Transform groundChecker;

    private bool movementIsLocked = false;


    private void Start()
    {
        body = GetComponent<Rigidbody>();
        groundChecker = transform.GetChild(0);
    }

    void Update()
    {
        //input.x = Input.GetAxis("Horizontal");
        //input.z = Input.GetAxis("Vertical");
        //if (input != Vector3.zero)
        //    transform.forward = input;
    }

    void FixedUpdate()
    {
        //body.MovePosition(body.position + input * Speed * Time.fixedDeltaTime);
        
    }

    public void SetInput()
    {
        input.z = Input.GetAxis("Horizontal");
        //input.x = Input.GetAxis("Vertical");
        //if (input != Vector3.zero)
            //transform.forward = input;
            //transform.forward = input;

            //if (Input.GetKeyDown(KeyCode.A))
            //{
            //    transform.localPosition. 
            //}



    }

    public void Move()
    {
        //body.MovePosition(body.position + input * Speed * Time.fixedDeltaTime);
        transform.Translate(input * Speed * Time.fixedDeltaTime);
    }

    public void Jump()
    {
        body.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
    
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
        Speed = newSpeed;
    }

    public float getSpeed()
    {
        return Speed;
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
}
