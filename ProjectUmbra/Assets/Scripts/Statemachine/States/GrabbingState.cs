using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/GrabbingState")]
public class GrabbingState : BaseState
{
    [SerializeField] private float movementSpeed = 5f;
    protected GameObject grabbedObject;
    

    public override void Enter()
    {
        //MovementHandler.setSpeed(movementSpeed);
        Debug.Log("grabbing");
    }

    public override void HandleUpdate()
    {
        base.HandleUpdate();
        MovementHandler.SetInput();
        
        if(grabHandler.GetGrabStatus() == false)
        {
            owner.Transition<WalkState>();
        }
       
    }
    public override void HandleFixedUpdate()
    {
        MovementHandler.Move();
    }
}