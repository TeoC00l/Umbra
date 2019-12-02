using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/ClimbState")]
public class ClimbState : BaseState
{

    //private PlayerMovement playerMovement;

        

    public override void Enter()
    {
        playerMovement = owner.GetComponent<PlayerMovement>();

        Debug.Log("Entered climb state");

        RotateMesh();

        playerBody.isKinematic = true;
        animator.SetBool("isClimbing", true);
        ColliderCalcBoundsUpper();

    }



    public override void HandleUpdate()
    {
        DeathComponent.cachedPosition = owner.transform.position;


        //if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        //{
        //    playerMovement.ExitLadder();

        //}else if (CloseToUpperColliderEdge() == false)
        //{
        //    playerMovement.MoveUpOnLadder();
        //    //SetClimbAnimationSpeed();

        //}
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        //{
        //    playerMovement.ExitLadder();

        //}
        //else if (CloseToLowerColliderEdge() == false)
        //{
        //    playerMovement.MoveDownOnLadder();
        //    //SetClimbAnimationSpeed();
        //}




        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            playerMovement.ExitLadder();

        }
        else if (ColliderCalcBoundsUpper() == false)
        {
            playerMovement.MoveUpOnLadder();
            //SetClimbAnimationSpeed();

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            playerMovement.ExitLadder();

        }
        else if (ColliderCalcBoundsLower() == false)
        {
            playerMovement.MoveDownOnLadder();
            //SetClimbAnimationSpeed();
        }

        if (ColliderCalcBoundsLower() == true || ColliderCalcBoundsUpper() == true)
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



    private bool ColliderCalcBoundsUpper()
    {
        float y = playerMovement.LadderCollider.size.y * playerMovement.LadderCollider.transform.localScale.y;
        //Vector3 sizeAndScale = new Vector3(0, playerMovement.LadderCollider.size.y * playerMovement.LadderCollider.transform.localScale.y, 0);
        float halfSize = y / 2;
        float yHalfExtent = playerMovement.LadderCollider.bounds.extents.y;
        float yCenter = playerMovement.LadderCollider.bounds.center.y;


        float yUpperPos = (playerMovement.LadderCollider.transform.position.y +  yHalfExtent)/* * playerMovement.LadderCollider.transform.localScale.y*/;
        //yUpperPos *= playerMovement.LadderCollider.transform.localScale.y;

        //yLowerPos *= playerMovement.LadderCollider.transform.localScale.y;

        Vector3 upperPos = new Vector3(0, yUpperPos, 0);



        Vector3 playerPos = new Vector3(0, playerMovement.transform.position.y, 0);
        float distance = Vector3.Distance(playerPos, upperPos);

        //Debug.Log(distance + " " + upperPos + " " + yCenter + " " + playerPos);
        if (distance < 3.5f)
        {
            return true;
        }
        return false;
        //Debug.Log(halfSize + " " + playerMovement.LadderCollider.transform.position + yUpperPos + " " + yLowerPos);
        //is it Lower and higher pos correct?

    }

    private bool ColliderCalcBoundsLower()
    {

        float yHalfExtent = playerMovement.LadderCollider.bounds.extents.y;
        float yCenter = playerMovement.LadderCollider.bounds.center.y;

        float yLowerPos = (playerMovement.LadderCollider.transform.position.y -  yHalfExtent) /** playerMovement.LadderCollider.transform.localScale.y*/;


        Vector3 playerPos = new Vector3(0, playerMovement.transform.position.y, 0);


        Vector3 lowerPos = new Vector3(0, yLowerPos, 0);
        float distanceToLower = Vector3.Distance(playerPos, lowerPos);



        //Debug.Log(distanceToLower + " " + lowerPos  +" " + yCenter + " " + playerPos);
        if (distanceToLower < 0.5f)
        {
            return true;
        }
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


    //first itteration of ladder y position calculation

    //private bool CloseToUpperColliderEdge()
    //{
    //    if (Vector3.Distance(owner.transform.position, playerMovement.upperLadderTransform.position) < 1.5f)
    //    {

    //        animator.speed = 0f;
    //        return true;
    //    }

    //    //Debug.Log(Vector3.Distance(owner.transform.position, playerMovement.upperLadderTransform.position));
    //    return false;
    //}

    //private bool CloseToLowerColliderEdge()
    //{

    //    if (Vector3.Distance(owner.transform.position, playerMovement.lowerLadderTransform.position) < 0.6f)
    //    {
    //        animator.speed = 0f;

    //        return true;
    //    }
    //    //Debug.Log(Vector3.Distance(owner.transform.position, playerMovement.upperLadderTransform.position));
    //    return false;
    //}

}
