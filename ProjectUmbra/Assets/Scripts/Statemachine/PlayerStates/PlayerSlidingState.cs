using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Player/PlayerSlideState")]
public class PlayerSlidingState : BaseState
{
    private int framesPassed;
    private LayerMask layerMask;

    public override void Enter()
    {
        layerMask = new LayerMask();
        layerMask = ~0;
        Debug.Log("Player enter slide state");
        animator.SetBool("isFalling", false);
        animator.SetBool("isSliding", true);
        framesPassed = 0;

    }

    public override void HandleFixedUpdate()
    {
        framesPassed++;
        if (playerMovement.IsGrounded() && framesPassed > 10)
        {

            owner.Transition<WalkState>();
        }

            if (!Physics.Raycast(owner.transform.position, Vector3.down, 5f, layerMask, QueryTriggerInteraction.Ignore))
            {
            animator.SetBool("isSliding", false);
            animator.SetBool("isFalling", true);
        }
    }

    public override void Exit()
    {
        animator.SetBool("isFalling", false);
        animator.SetBool("isSliding", false);
    }
}
