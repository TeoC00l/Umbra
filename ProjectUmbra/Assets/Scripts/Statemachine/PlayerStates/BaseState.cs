using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/BaseState")]
public class BaseState : State
{
    protected Player owner;
    protected PlayerMovement MovementHandler;
    protected BoxCollider playerCollider;
    private bool onSetup;
    protected GrabObject grabHandler;
    protected Rigidbody playerBody;
    protected Animator animator;
    protected Transform characterModel;
    protected bool runningBack;


    public override void Initialize(StateMachine owner)
    {
        this.owner = (Player)owner;
        MovementHandler = owner.GetComponent<PlayerMovement>();
        playerCollider = owner.GetComponent<BoxCollider>();
        grabHandler = owner.GetComponentInChildren<GrabObject>();
        playerBody = owner.GetComponent<Rigidbody>();
        animator = owner.GetComponentInChildren<Animator>();
        characterModel = owner.transform.Find("Idle");
    }

    public override void Enter()
    {
        onSetup = true;
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

        if (MovementHandler.getLadderStatus())
        {
            owner.Transition<ClimbState>();
        }

    }

    public override void HandleFixedUpdate()
    {
        
    }

    public override void Exit()
    {
       
    }
}