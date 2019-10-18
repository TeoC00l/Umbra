using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/BaseState")]
public class BaseState : State
{
    protected Player owner;
    protected PlayerMovement MovementHandler;
    protected BoxCollider playerCollider;
    private bool onSetup = true;
    protected GrabObject grabHandler;
    protected Rigidbody playerBody;

    public override void Initialize(StateMachine owner)
    {
        this.owner = (Player)owner;
        MovementHandler = owner.GetComponent<PlayerMovement>();
        playerCollider = owner.GetComponent<BoxCollider>();
        grabHandler = owner.GetComponentInChildren<GrabObject>();
        playerBody = owner.GetComponent<Rigidbody>();
    }

    public override void Enter()
    {
        base.Enter();
        
    }

    public override void HandleUpdate()
    {
        if (onSetup) {
            onSetup = false;
            owner.Transition<WalkState>();
        }
        
        if (MovementHandler.getLocked())
        {
            owner.Transition<TurnState>();
        }

        if (grabHandler.GetGrabStatus() == true)
        {
            owner.Transition<GrabbingState>();
        }
        
    }

    public override void HandleFixedUpdate()
    {
        
    }
}