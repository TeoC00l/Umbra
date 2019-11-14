using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Companion/WalkState")]

public class CompanionWalkState : CompanionBaseState
{

    public override void Enter()
    {
        //Play animation
        //Debug.Log("enter WalkState " + owner.gameObject.name);
        
        thisAgent.isStopped = false;
        thisAgent.SetDestination(owner.TargetPlayer.transform.position);

    }


    public override void HandleUpdate()
    {
        base.HandleUpdate();
        if (companionHandler.NotCloseToDestinationCheck(thisAgent) == false || owner.TargetIsToFarInYAxis())
        {
            owner.TargetIsToFarInYAxis();
            owner.Transition<CompanionIdelState>();
            companionAnimator.SetBool("IsWalking", false);
        }
        else
        {
            owner.TargetIsToFarInYAxis();
            thisAgent.SetDestination(owner.TargetPlayer.transform.position);

            //characterModel.LookAt(owner.TargetPlayer.transform.position);

            companionAnimator.SetBool("IsWalking", true);
        }
    }


    public override void Exit()
    {
        companionAnimator.SetBool("IsWalking", false);
    }




}
