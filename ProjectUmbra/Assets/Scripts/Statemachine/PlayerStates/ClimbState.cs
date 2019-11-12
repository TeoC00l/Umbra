using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/ClimbState")]
public class ClimbState : BaseState
{

    public override void Enter()
    {
        Debug.Log("Climb state");
        playerBody.isKinematic = true;
        animator.SetBool("isClimbing", true);

    }

    public override void HandleUpdate()
    {
        MovementHandler.MoveOnLadder();

        if (!MovementHandler.getLadderStatus() /*&& ObjectHandeler.Player.GetComponent<Player>().isClimbing == false*/)
        {
            owner.Transition<WalkState>();
        }
    }
    public override void Exit()
    {
        animator.SetBool("isClimbing", false);
        playerBody.isKinematic = false;
    }
}
