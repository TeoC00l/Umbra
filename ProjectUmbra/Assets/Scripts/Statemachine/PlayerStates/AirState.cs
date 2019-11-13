using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/AirState")]
public class AirState : BaseState
{
    public int framesPassed;

    public override void Enter()
    {
        framesPassed = 0;
    }

    public override void HandleUpdate()
    {
        framesPassed++;
        MovementHandler.SetInput();

        base.HandleUpdate();
    }
    public override void HandleFixedUpdate()
    {
        if (MovementHandler.IsGrounded() && framesPassed > 10)
        {
            animator.SetBool("isJumping", false);
            owner.Transition<WalkState>();
        }

        MovementHandler.Move();
    }

    public override void Exit()
    {
        animator.SetBool("isJumping", false);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isIdle", true);
        }
    }
}
