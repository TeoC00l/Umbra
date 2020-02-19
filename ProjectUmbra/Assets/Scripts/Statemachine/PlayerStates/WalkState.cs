using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/WalkState")]
public class WalkState : BaseState
{
    private int idleFrames;

    //Walking animation control
    public override void Enter()
    {
        playerMovement.setSpeed(10);
        idleFrames = 0;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isIdle", true);
        }
    }

    //Jump and push control, setting input axis
    public override void HandleUpdate()
    {
        idleFrames++;

        animator.SetBool("isPushing", false);
        turnMesh();
        PlayWalkAnimation();

        if (Input.GetKeyDown(KeyCode.Space) && playerMovement.IsGrounded())
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", false);
            animator.SetBool("isJumping", true);
            playerMovement.Jump();
            owner.Transition<AirState>();
        }

        if (LookForWall() == true)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", true);
        }

        if (LookForPushObject() && Input.GetKey(KeyCode.D) || LookForPushObject() && Input.GetKey(KeyCode.A))
        {
            ChangeToPushAnimation();
        }

        if (LookForBridge() == true)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isPushing", true);
        }
        base.HandleUpdate();
        playerMovement.SetInput();
    }

    //Move character
    public override void HandleFixedUpdate()
    {
        playerMovement.Move();
    }


    public override void Exit()
    {
        animator.SetBool("isWalking", false);
        animator.SetBool("isIdle", false);
    }


    private bool LookForWall()
    {
        return (Physics.Raycast(owner.transform.position, characterModel.transform.forward, 0.5f, owner.WallLayer));
    }

    private bool LookForPushObject()
    {
        return (Physics.Raycast(owner.transform.position, characterModel.transform.forward, 0.5f, playerMovement.boxes));
    }



    private void ChangeToPushAnimation()
    {
        if (LookForPushObject())
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isWalking", false);
            animator.SetBool("isPushing", false);
        }
    }


    private void PlayWalkAnimation()
    {
            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);
                idleFrames = 0;
            }

            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);
                idleFrames = 0;
            }

            if ((Input.GetAxis("Horizontal") == 0 && idleFrames > 3) || (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D) && idleFrames > 3))
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isIdle", true);
            }
            else
            {
                idleFrames++;
            }       
    }
}