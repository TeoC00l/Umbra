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
        MovementHandler.SetInput();
        
        if (MovementHandler.IsGrounded())
        {
            owner.Transition<WalkState>();
        }
    }
    public override void HandleFixedUpdate()
    {
        MovementHandler.Move();
    }
}
