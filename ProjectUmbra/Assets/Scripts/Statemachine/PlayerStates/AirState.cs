using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/AirState")]
public class AirState : BaseState
{
    public int framesPassed;

    //Animation control and setting player collider material to disallow from jumping on walls
    public override void Enter()
    {
        framesPassed = 0;
        animator.SetBool("isFalling", true);
        //animator.SetBool("isWalking", false);
        //animator.SetBool("isIdle", false);
        //animator.SetBool("isJumping", true);
        playerCollider.material = owner.wallMaterial;
    }

    //Checking when to start falling animation, checking ground collision
    public override void HandleUpdate()
    {
        framesPassed++;
        playerMovement.SetInput();

        turnMesh();
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

    //Moving player
    public override void HandleFixedUpdate()
    {

        playerMovement.Move();
    }

    //Animation control
    public override void Exit()
    {
        animator.SetBool("isFalling", false);
        animator.SetBool("isJumping", false);
        playerCollider.material = null;
        
    }
}
