using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Companion/IdelState")]
public class CompanionIdelState : CompanionBaseState
{

    public override void Enter()
    {
        //play Animation

        //Debug.Log("enter idelState " + owner.gameObject.name);
        owner.iconSprite.color = new Color(49f, 22f, 41f, 0.56f);
        thisAgent.isStopped = true;
        owner.isWaiting = false;

    }


    public override void HandleUpdate()
    {

        base.HandleUpdate();
        if (companionHandler.NotCloseToDestinationCheck(thisAgent) == true && owner.isWaiting == false)
        {

            owner.Transition<CompanionWalkState>();


        }
    }




}
