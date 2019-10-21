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
    }

    public override void HandleUpdate()
    {
        MovementHandler.MoveOnLadder();

        if (!MovementHandler.getLadderStatus())
        {
            owner.Transition<WalkState>();
        }
    }
    public override void Exit()
    {
        playerBody.isKinematic = false;
    }
}
