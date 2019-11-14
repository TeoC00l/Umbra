//TODO: Göra metoder private

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //Attributes
    private Vector3 input, verticalLadderInput, horizontalLadderInput;

    private Rigidbody rb;
    private Transform groundChecker;

    [SerializeField]private bool isMovementLocked, isOnLadder, isJumping;

    [SerializeField] private float speed, topSpeed, jumpHeight, fallMultiplier, groundDistance;
    [SerializeField] private LayerMask Ground, layerMask;

    public GameObject cornerTurner;
    public Vector3 veloc;
    public int cornerTurnerMode;
    //Cornerturn mode is a value 0-3
    //0 is forward, 1 is right, 2 is back, and 3 is left
    //this value serves to identify the rotation of the players character


    [SerializeField] private GameObject alice, set;

    public RaycastHit SlideRayCastHit;
    [SerializeField] private LayerMask slideMask;
    [SerializeField] public GameObject CurrentLadder;


    //Methods
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Whitebox_lvl1")
        {
            cornerTurnerMode = 1;
        }
        else if (sceneName == "WhiteBox_lvl2")
        {
            cornerTurnerMode = 3;
        }
        else if (sceneName == "Prologue_Gameplay")
        {
            cornerTurnerMode = 3;
        }

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



    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ladder"))
        {
            CurrentLadder = other.gameObject;
        }
    }
}
