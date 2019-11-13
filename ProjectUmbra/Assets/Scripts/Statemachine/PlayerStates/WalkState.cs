using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/WalkState")]
public class WalkState : BaseState
{
    public override void Enter()
    {
        animator.SetBool("isIdle", true);
    }

    public override void HandleUpdate()
    {
        if (Input.GetAxis("Horizontal") == 0 || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", true);
        }
        else
        if (Input.GetAxis("Horizontal") > 0)
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);

            if (runningBack == true)
            {
                characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, 180f);
                runningBack = false;
            }

        }
        else
        if (Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);

            if (runningBack == false)
            {
                characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, 180f);
                runningBack = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && MovementHandler.IsGrounded())
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", false);
            animator.SetBool("isJumping", true);
            MovementHandler.Jump();
            owner.Transition<AirState>();
        }


        base.HandleUpdate();
        MovementHandler.SetInput();
    }
    public override void HandleFixedUpdate()
    {
        MovementHandler.Move();
    }


    public override void Exit()
    {
        animator.SetBool("isWalking", false);
        animator.SetBool("isIdle", false);
    }
}