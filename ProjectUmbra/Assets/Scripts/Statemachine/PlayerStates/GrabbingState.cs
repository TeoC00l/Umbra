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
        

    }
    private void playAnimation()
    {

        if (grabHandler.IsBoxInFront())
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.SetBool("isPushing", true);
                animator.SetBool("isPulling", false);
            }

            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.SetBool("isPushing", false);
                animator.SetBool("isPulling", true);
            }
        }

        if (!grabHandler.IsBoxInFront())
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.speed = 1;

                animator.SetBool("isPushing", false);
                animator.SetBool("isPulling", true);
            }

            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.speed = 1;

                animator.SetBool("isPushing", true);
                animator.SetBool("isPulling", false);
            }
        }

        if (Input.GetAxis("Horizontal") == 0)
        {
            animator.speed = 0;
        }



    }

}