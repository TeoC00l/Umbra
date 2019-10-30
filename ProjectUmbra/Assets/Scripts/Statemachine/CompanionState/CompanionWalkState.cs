using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Companion/WalkState")]

public class CompanionWalkState : CompanionBaseState
{

    public override void Enter()
    {
        //Play animation
        //Debug.Log("enter WalkState " + owner.gameObject.name );
        agent.isStopped = false;
        agent.SetDestination(owner.TargetPlayer.transform.position);

    }


    public override void HandleUpdate()
    {
        base.HandleUpdate();
        if (companionHandler.NotCloseToDestinationCheck(agent) == false)
        {
            owner.Transition<CompanionIdelState>();
        }
        else
        {
            agent.SetDestination(owner.TargetPlayer.transform.position);
        }



        




    }




}
