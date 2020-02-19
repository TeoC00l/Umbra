using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/GrabbingState")]
public class GrabbingState : BaseState
{
    [SerializeField] private float movementSpeed = 5f;
    protected GameObject grabbedObject;

    

    public override void Enter()
    {
        Debug.Log("grabbing");

        playerMovement.setSpeed(4);
    }

    public override void HandleUpdate()
    {
        base.HandleUpdate();
        playerMovement.SetInput();

        playAnimation();

        if (grabHandler.GetGrabStatus() == false)
        {
            owner.Transition<WalkState>();
        }
       
    }
    public override void HandleFixedUpdate()
    {
        playerMovement.Move();
    }

    public override void Exit()
    {
        animator.speed = 1;
        animator.SetBool("isPulling", false);
        animator.SetBool("isPushing", false);
        playerMovement.setSpeed(10);
        

    }
    private void playAnimation()
    {

        if (grabHandler.IsBoxInFront())
        {
            Debug.Log("Box is infront");
            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.SetBool("isPushing", false);
                animator.SetBool("isPulling", true);
            }

            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.SetBool("isPushing", true);
                animator.SetBool("isPulling", false);
            }
        }

        if (!grabHandler.IsBoxInFront())
        {
            Debug.Log("Box is");
            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.speed = 1;

                animator.SetBool("isPushing", true);
                animator.SetBool("isPulling", false);
            }

            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.speed = 1;

                animator.SetBool("isPushing", false);
                animator.SetBool("isPulling", true);
            }
        }

        if (Input.GetAxis("Horizontal") == 0)
        {
            animator.speed = 0;
        }



    }

}