using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Companion/JumpState")]
public class CompanionJumpState : CompanionBaseState
{



    public override void Enter()
    {
        Debug.Log("enter CompanionJumpState");
        //Play animation

    }



    public override void HandleUpdate()
    {
        
        if(agent.isOnOffMeshLink == false)
        {
            owner.Transition<CompanionWalkState>();
        }
    }





}
