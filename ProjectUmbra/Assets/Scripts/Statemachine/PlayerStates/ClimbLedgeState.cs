using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Player/ClimbeLedgeState")]

public class ClimbLedgeState : BaseState
{
    private float climb = 3.5f;


    public override void Enter()
    {

        Debug.Log("ClimbLedgeState");
        animator.SetBool("isClimbing", true);
    }



    public override void HandleUpdate()
    {
        if(climb > 0)
        {
            climb -= Time.deltaTime;
        }
        else
        {
            climb = 3.5f;
            animator.SetBool("isClimbing", false);
            animator.SetBool("isWalking", false);
            animator.SetBool("isJumping", false);


            ObjectHandeler.Player.GetComponent<Player>().Transition<BaseState>();
        }
    }
    public override void Exit()
    {
        //owner.transform.position = owner.ClimbToTransform.position;

    }



}
