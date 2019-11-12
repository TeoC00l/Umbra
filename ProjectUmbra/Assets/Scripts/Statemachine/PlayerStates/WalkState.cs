using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/WalkState")]
public class WalkState : BaseState
{
    public override void Enter()
    {
        //Debug.Log("walkstate");
    }

    public override void HandleUpdate()
    {
       
        bool isWalkingPressed = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
        animator.SetBool("isWalking", isWalkingPressed);

        base.HandleUpdate();
        MovementHandler.SetInput();

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (runningBack == false)
            {
                characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, 180f);
                runningBack = true;
            }
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            if (runningBack == true)
            {
                characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, 180f);
                runningBack = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) && MovementHandler.IsGrounded())
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isJumping", true);
            MovementHandler.Jump();
            owner.Transition<AirState>();
        }
    }
    public override void HandleFixedUpdate()
    {
        MovementHandler.Move();


    }


    public override void Exit()
    {
        animator.SetBool("isWalking", false);
    }
}