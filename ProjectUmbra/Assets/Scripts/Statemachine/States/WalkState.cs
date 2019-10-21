using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/WalkState")]
public class WalkState : BaseState
{
    //[SerializeField] private float movementSpeed = 5f;
    public override void Enter()
    {
        //MovementHandler.setSpeed(movementSpeed);
        Debug.Log("walkstate");
    }

    public override void HandleUpdate()
    {
        base.HandleUpdate();
        MovementHandler.SetInput();
        Debug.Log(MovementHandler.isGrounded());
        if (Input.GetKeyDown(KeyCode.Space) && MovementHandler.isGrounded())
        {
            MovementHandler.Jump();
            owner.Transition<AirState>();
        }
    }
    public override void HandleFixedUpdate()
    {
        MovementHandler.Move();
        //Debug.Log("fixed");

    }


    public override void Exit()
    {
        //Debug.Log("exit walkstate");
    }
}