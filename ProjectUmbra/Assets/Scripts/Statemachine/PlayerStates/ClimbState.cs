using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/ClimbState")]
public class ClimbState : BaseState
{

    public override void Enter()
    {
        if (runningBack)
        {
            characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, 270f);
        }
        else
        {
            characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, -270f);
        }

        playerBody.isKinematic = true;
        animator.SetBool("isClimbing", true);
        //animator.SetBool("isIdle", true);
        Debug.Log("Climbing");
    }

    public override void HandleUpdate()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isClimbing", true);
            animator.speed = 2f;

        }
        else
        {
            animator.SetBool("isClimbing", false);
            animator.speed = 0f;
        }

        MovementHandler.MoveOnLadder();

        if (!MovementHandler.getLadderStatus())
        {
            owner.Transition<WalkState>();
        }
    }

    public override void Exit()
    {
        if (runningBack)
        {
            characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, -270f);
        }
        else
        {
            characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, -270f);
        }

        animator.speed = 1f;
        animator.SetBool("isClimbing", false);
        playerBody.isKinematic = false;
    }
}
