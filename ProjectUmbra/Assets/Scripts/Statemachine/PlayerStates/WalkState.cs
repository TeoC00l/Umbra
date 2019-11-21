using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/WalkState")]
public class WalkState : BaseState
{
    public override void Enter()
    {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("isIdle", true);
        }
    }

    public override void HandleUpdate()
    {
        turnMesh();

        if (Input.GetKeyDown(KeyCode.Space) && playerMovement.IsGrounded())
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", false);
            animator.SetBool("isJumping", true);
            playerMovement.Jump();
            owner.Transition<AirState>();
        }

        base.HandleUpdate();
        playerMovement.SetInput();
    }

    public override void HandleFixedUpdate()
    {
        playerMovement.Move();
    }


    public override void Exit()
    {
        animator.SetBool("isWalking", false);
        animator.SetBool("isIdle", false);
    }

    private void turnMesh()
    {
        if (playerMovement.cornerTurnerMode == 0)
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



        if (playerMovement.cornerTurnerMode == 1)
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



        if (playerMovement.cornerTurnerMode == 2)
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


        if (playerMovement.cornerTurnerMode == 3)
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
    }
}