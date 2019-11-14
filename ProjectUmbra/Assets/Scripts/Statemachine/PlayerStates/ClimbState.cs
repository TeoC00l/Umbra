using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/ClimbState")]
public class ClimbState : BaseState
{

    public override void Enter()
    {
        if (movementHandler.cornerTurnerMode == 0)
        {
            characterModel.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
        }

        if (movementHandler.cornerTurnerMode == 1)
        {
            characterModel.transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
        }

        if (movementHandler.cornerTurnerMode == 2)
        {
            characterModel.transform.rotation = Quaternion.LookRotation(Vector3.back, Vector3.up);
        }

        if (movementHandler.cornerTurnerMode == 3)
        {
            characterModel.transform.rotation = Quaternion.LookRotation(Vector3.left, Vector3.up);
        }       

        playerBody.isKinematic = true;
        animator.SetBool("isClimbing", true);

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
