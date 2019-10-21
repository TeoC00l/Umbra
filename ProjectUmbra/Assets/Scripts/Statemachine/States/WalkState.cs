using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/WalkState")]
public class WalkState : BaseState
{
    public override void Enter()
    {
        Debug.Log("walkstate");
    }

    public override void HandleUpdate()
    {
        base.HandleUpdate();
        MovementHandler.SetInput();
        if (Input.GetKeyDown(KeyCode.Space) && MovementHandler.isGrounded())
        {
            MovementHandler.Jump();
            owner.Transition<AirState>();
        }
    }
    public override void HandleFixedUpdate()
    {
        MovementHandler.Move();

    }


    public override void Exit()
    {
    }
}