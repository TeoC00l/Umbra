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
    protected DeathComponent deathComponent;
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
        if (owner.TryGetComponent(out DeathComponent dC))
        {
            deathComponent = dC;
        }
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
        if (onSetup)
        {
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
        if (playerMovement.getSpeed() == 0)
        {
            owner.Transition<DialogueState>();
        }
    }





    protected bool LookForBridge()
    {
        return (Physics.Raycast(characterModel.transform.position + new Vector3(0, 0.5f, 0), characterModel.forward, 1f, owner.Bridge)) ;
    }



    protected void turnMesh()
    {
        if (playerMovement.cornerTurnerMode == 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {

                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") < 0)
            {


                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.left, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") == 0 || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
            {

            }
        }



        if (playerMovement.cornerTurnerMode == 1)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {


                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.back, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") < 0)
            {


                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") == 0 || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
            {

            }
        }



        if (playerMovement.cornerTurnerMode == 2)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {


                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.left, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") < 0)
            {


                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") == 0 || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
            {

            }
        }


        if (playerMovement.cornerTurnerMode == 3)
        {

            if (Input.GetAxis("Horizontal") > 0)
            {


                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") < 0)
            {


                characterModel.transform.rotation = Quaternion.LookRotation(Vector3.back, Vector3.up);
            }

            if (Input.GetAxis("Horizontal") == 0 || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
            {

            }
        }
    }



}