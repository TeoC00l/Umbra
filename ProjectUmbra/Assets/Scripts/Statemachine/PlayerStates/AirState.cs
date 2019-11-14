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
        movementHandler.SetInput();

        base.HandleUpdate();
    }
    public override void HandleFixedUpdate()
    {
        if (movementHandler.IsGrounded() && framesPassed > 10)
        {
            animator.SetBool("isJumping", false);
            owner.Transition<WalkState>();
        }

        movementHandler.Move();
    }

    public override void Exit()
    {
        animator.SetBool("isJumping", false);
    }
}
