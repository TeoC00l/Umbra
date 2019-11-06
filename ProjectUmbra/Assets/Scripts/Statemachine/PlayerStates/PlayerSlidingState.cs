using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Player/PlayerSlideState")]
public class PlayerSlidingState : BaseState
{



    public override void Enter()
    {
        Debug.Log("Player enter slide state");


    }

    public override void HandleFixedUpdate()
    {
        if (MovementHandler.IsGrounded())
        {

            owner.Transition<WalkState>();
        }
    }


}
