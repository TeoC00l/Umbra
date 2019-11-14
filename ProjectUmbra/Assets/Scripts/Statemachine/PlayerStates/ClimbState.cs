using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/ClimbState")]
public class ClimbState : BaseState
{

    public override void Enter()
    {
        //characterModel.transform.LookAt(CurrentLadder.transform, Vector3.up);
        
        //if (runningBack)
        //{
        //characterModel.transform.LookAt(MovementHandler.CurrentLadder.transform.GetChild(1));
        if (movementHandler.cornerTurner.GetComponent<CornerTurner>().GetTurnDirection())
        {
            characterModel.transform.rotation = Quaternion.LookRotation(Vector3.left, Vector3.up);
        }
        else
        {
            characterModel.transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
        }

        //    //characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, 270f);
        //}
        //else
        //{

        //    characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, -270f);
        //}

        playerBody.isKinematic = true;
        animator.SetBool("isClimbing", true);
        //animator.SetBool("isIdle", true);
        Debug.Log("Climbing");
    }

    public override void HandleUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isClimbing", true);
            animator.speed = 2f;

        }
        else
        {
            animator.SetBool("isClimbing", false);
            animator.speed = 0f;
        }

        movementHandler.MoveOnLadder();

        if (!movementHandler.getLadderStatus())
        {
            owner.Transition<WalkState>();
        }
    }

    public override void Exit()
    {
        animator.speed = 1f;
        animator.SetBool("isClimbing", false);
        playerBody.isKinematic = false;
    }
}
