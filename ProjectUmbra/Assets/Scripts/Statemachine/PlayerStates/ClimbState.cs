using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/ClimbState")]
public class ClimbState : BaseState
{

    //private PlayerMovement playerMovement;

    public override void Enter()
    {
        Debug.Log("Entered climb state");

        RotateMesh();

        playerBody.isKinematic = true;
        animator.SetBool("isClimbing", true);

        playerMovement = owner.GetComponent<PlayerMovement>();       
    }



    public override void HandleUpdate()
    {
        DeathComponent.cachedPosition = owner.transform.position;


        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            playerMovement.ExitLadder();

        }else if (CloseToUpperColliderEdge() == false)
        {
            playerMovement.MoveUpOnLadder();
            //SetClimbAnimationSpeed();

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            playerMovement.ExitLadder();

        }
        else if (CloseToLowerColliderEdge() == false)
        {
            playerMovement.MoveDownOnLadder();
            //SetClimbAnimationSpeed();
        }

        if (CloseToUpperColliderEdge() == true || CloseToLowerColliderEdge() == true)
        {
            animator.speed = 0f;
        }
        else
        {
            SetClimbAnimationSpeed();
        }






        if (!playerMovement.getLadderStatus())
        {
            owner.Transition<AirState>();
        }
    }


    public override void Exit()
    {
        animator.speed = 1f;
        animator.SetBool("isClimbing", false);
        playerBody.isKinematic = false;
    }



    private void SetClimbAnimationSpeed()
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
    }





    private bool CloseToUpperColliderEdge()
    {
        if (Vector3.Distance(owner.transform.position, playerMovement.upperLadderTransform.position) < 1.5f)
        {

            animator.speed = 0f;
            return true;
        }

        //Debug.Log(Vector3.Distance(owner.transform.position, playerMovement.upperLadderTransform.position));
        return false;
    }

    private bool CloseToLowerColliderEdge()
    {

        if (Vector3.Distance(owner.transform.position, playerMovement.lowerLadderTransform.position) < 0.6f)
        {
            animator.speed = 0f;

            return true;
        }
        //Debug.Log(Vector3.Distance(owner.transform.position, playerMovement.upperLadderTransform.position));
        return false;
    }
    private void RotateMesh()
    {
        if (playerMovement.cornerTurnerMode == 0)
        {
            characterModel.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
        }

        if (playerMovement.cornerTurnerMode == 1)
        {
            characterModel.transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
        }

        if (playerMovement.cornerTurnerMode == 2)
        {
            characterModel.transform.rotation = Quaternion.LookRotation(Vector3.back, Vector3.up);
        }

        if (playerMovement.cornerTurnerMode == 3)
        {
            characterModel.transform.rotation = Quaternion.LookRotation(Vector3.left, Vector3.up);
        }
    }

}
