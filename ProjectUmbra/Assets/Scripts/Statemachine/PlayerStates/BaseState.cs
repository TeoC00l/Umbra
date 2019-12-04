using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/BaseState")]
public class BaseState : State
{
    #region Properties
    protected Player owner;
    protected PlayerMovement playerMovement;
    protected CapsuleCollider playerCollider;

    private bool onSetup;
    protected bool runningBack;

    protected GrabObject grabHandler;
    protected Rigidbody playerBody;
    protected Animator animator;
    protected Transform characterModel;
    protected LayerMask boxLayerMask;
    #endregion

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

    //Continual checks that are made during all states
    public override void HandleUpdate()
    {
        //Startup method to transition from the base state
        if (onSetup) {
            onSetup = false;
            owner.Transition<WalkState>();
        }
        
        //Is player turning a corner
        if (playerMovement.getLocked())
        {
            owner.Transition<TurnState>();
        }

        //Is player grabbing something
        if (grabHandler.GetGrabStatus() == true)
        {
            owner.Transition<GrabbingState>();
        }

        //Is player on ladder
        if (playerMovement.getLadderStatus())
        {
            owner.Transition<ClimbState>();
        }

        //Is player currently in a dialogue
        if(playerMovement.getSpeed() == 0)
        {
            owner.Transition<DialogueState>();
        }
    }
}