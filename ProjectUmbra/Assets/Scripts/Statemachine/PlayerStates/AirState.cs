using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/AirState")]
public class AirState : BaseState
{
    public override void Enter()
    {
    }

    public override void HandleUpdate()
    {

        //if (Input.GetAxis("Horizontal") == 0 || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
        //{
        //    //Do nothing
        //}
        //else
        //if (Input.GetAxis("Horizontal") > 0)
        //{
        //    if (runningBack == true)
        //    {
        //        characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, 180f);
        //        runningBack = false;
        //    }

        //}
        //else
        //if (Input.GetAxis("Horizontal") < 0)
        //{
        //    if (runningBack == false)
        //    {
        //        characterModel.transform.RotateAround(characterModel.transform.position, characterModel.transform.up, 180f);
        //        runningBack = true;
        //    }
        //}


        //base.HandleUpdate();
        MovementHandler.SetInput();
        
        if (MovementHandler.IsGrounded())
        {
            animator.SetBool("isJumping", false);
            owner.Transition<WalkState>();
        }
    }
    public override void HandleFixedUpdate()
    {
        MovementHandler.Move();
    }

    public override void Exit()
    {
        animator.SetBool("isJumping", false);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isIdle", true);
        }
    }
}
