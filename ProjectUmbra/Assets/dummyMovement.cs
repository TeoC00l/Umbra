using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyMovement : MonoBehaviour
{
    private float speed;
    private Rigidbody rb;
    private Vector3 forwardAxis;
    private float jumpForce;
    private bool isJumping;
    [SerializeField] private float JumpHeight = 2f;



    // Start is called before the first frame update
    void Start()
    {
        speed = 50;
        jumpForce = 200;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardAxis.z = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {

        if(rb.velocity.magnitude < 10)
        {
            rb.velocity += forwardAxis * speed * Time.fixedDeltaTime;
        }      
        
        if(isJumping == true)
        {
            rb.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
            isJumping = false;
        }
    }
}
