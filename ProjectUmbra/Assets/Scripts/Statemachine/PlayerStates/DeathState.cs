using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/DialogueState")]
public class DeathState : BaseState
{
    public int framesPassed;

    public override void Enter()
    {
        animator.SetBool("isIdle", true);
    }

    public override void HandleUpdate()
    {
        if (playerMovement.getSpeed() != 0)
        {
            owner.Transition<WalkState>();
        }
    }
    public override void HandleFixedUpdate()
    {
    }

    public override void Exit()
    {

        animator.SetBool("isIdle", false);
    }
}
