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
        animator.SetBool("isFalling", true);
        playerCollider.material = owner.wallMaterial;
    }

    public override void HandleUpdate()
    {
        framesPassed++;
        playerMovement.SetInput();

        if(framesPassed > 20)
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", true);

        }

        if (playerMovement.IsGrounded() && framesPassed > 10)
        {
            animator.SetBool("isFalling", false);

            owner.Transition<WalkState>();
        }

        base.HandleUpdate();
    }
    public override void HandleFixedUpdate()
    {

        playerMovement.Move();
    }

    public override void Exit()
    {
        animator.SetBool("isFalling", false);
        animator.SetBool("isJumping", false);
        playerCollider.material = null;
        
    }
}
