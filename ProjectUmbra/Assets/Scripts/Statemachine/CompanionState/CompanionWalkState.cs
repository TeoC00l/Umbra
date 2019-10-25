using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Companion/WalkState")]

public class CompanionWalkState : CompanionBaseState
{

    public override void Enter()
    {
        base.Enter();
        //Play animation
        Debug.Log("enter WalkState Companion");
        agent.SetDestination(owner.TargetPlayer.transform.position);
        agent.isStopped = false;
    }


    public override void HandleUpdate()
    {
        if(companionHandler.NotCloseToDestinationCheck(agent) == false)
        {
            owner.Transition<CompanionIdelState>();
        }
    }




}
