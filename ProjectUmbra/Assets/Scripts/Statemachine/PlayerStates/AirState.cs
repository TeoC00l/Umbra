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
        playerMovement.SetInput();

        base.HandleUpdate();
    }
    public override void HandleFixedUpdate()
    {
        if (playerMovement.IsGrounded() && framesPassed > 10)
        {
            animator.SetBool("isJumping", false);
            owner.Transition<WalkState>();
        }

        playerMovement.Move();
    }

    public override void Exit()
    {
        animator.SetBool("isJumping", false);
        
    }
}
