using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/ClimbState")]
public class ClimbState : BaseState
{

    public override void Enter()
    {
        //characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, 270f);
        playerBody.isKinematic = true;
        //animator.SetBool("isClimbing", true);
        animator.SetBool("isIdle", true);
        Debug.Log("Climbing");
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
        //characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, -270f);
        //animator.SetBool("isClimbing", false);
        animator.SetBool("isIdle", true);
        playerBody.isKinematic = false;
    }
}
