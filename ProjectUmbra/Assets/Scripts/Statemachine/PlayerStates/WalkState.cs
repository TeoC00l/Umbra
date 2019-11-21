using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/WalkState")]
public class WalkState : BaseState
{
    public override void Enter()
    {
        animator.SetBool("isIdle", true);
        //playerBody.velocity = Vector3.zero;
    }

    public override void HandleUpdate()
    {
        if (movementHandler.cornerTurnerMode == 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);

                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);

                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.left, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") == 0 || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isIdle", true);
            }
        }



        if (movementHandler.cornerTurnerMode == 1)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);

                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.back, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);

                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") == 0 || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isIdle", true);
            }
        }



        if (movementHandler.cornerTurnerMode == 2)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);

                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.left, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);

                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") == 0 || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isIdle", true);
            }
        }


        if (movementHandler.cornerTurnerMode == 3)
        {

            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);

                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isIdle", false);

                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.back, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") == 0 || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isIdle", true);
            }
        }



        if (Input.GetKeyDown(KeyCode.Space) && movementHandler.IsGrounded())
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", false);
            animator.SetBool("isJumping", true);
            movementHandler.Jump();
            owner.Transition<AirState>();
        }

        base.HandleUpdate();
        movementHandler.SetInput();
    }

    public override void HandleFixedUpdate()
    {
        movementHandler.Move();
    }


    public override void Exit()
    {
        animator.SetBool("isWalking", false);
        animator.SetBool("isIdle", false);
    }
}