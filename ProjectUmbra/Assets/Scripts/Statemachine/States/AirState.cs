using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/AirState")]
public class AirState : BaseState
{
    public override void Enter()
    {
        //Debug.Log("Airstate");
    }

    public override void HandleUpdate()
    {
        base.HandleUpdate();
        if (MovementHandler.isGrounded())
        {
            owner.Transition<WalkState>();
        }
    }
}
