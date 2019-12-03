using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/BaseState")]
public class BaseState : State
{
    protected Player owner;
    protected PlayerMovement playerMovement;
    protected CapsuleCollider playerCollider;
    private bool onSetup;
    protected GrabObject grabHandler;
    protected Rigidbody playerBody;
    protected Animator animator;
    protected Transform characterModel;
    protected bool runningBack;
    protected LayerMask boxLayerMask;

    public override void Initialize(StateMachine owner)
    {
        this.owner = (Player)owner;
        playerMovement = owner.GetComponent<PlayerMovement>();
        playerCollider = owner.GetComponent<CapsuleCollider>();
        grabHandler = owner.GetComponentInChildren<GrabObject>();
        playerBody = owner.GetComponent<Rigidbody>();
        animator = owner.GetComponentInChildren<Animator>();
        characterModel = owner.transform.Find("Idle");
    }

    public override void Enter()
    {
        onSetup = true;
        base.Enter();
        boxLayerMask = 11;

    }

    public override void HandleUpdate()
    {
        if (onSetup) {
            onSetup = false;
            owner.Transition<WalkState>();
        }
        
        if (playerMovement.getLocked())
        {
            owner.Transition<TurnState>();
        }

        if (grabHandler.GetGrabStatus() == true)
        {
            owner.Transition<GrabbingState>();
        }

        if (playerMovement.getLadderStatus())
        {
            owner.Transition<ClimbState>();
        }

        if(playerMovement.getSpeed() == 0)
        {
            owner.Transition<DialogueState>();
        }
    }

    public override void HandleFixedUpdate()
    {
        
    }

    public override void Exit()
    {
       
    }
}