using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "Companion/BaseState")]
public class CompanionBaseState : CompanionState
{
    protected Companion owner;
    protected CompanionHandler companionHandler;
    protected Rigidbody compaionRB;
    protected NavMeshAgent thisAgent;
    protected Animator companionAnimator;
    protected Transform characterModel;


    private bool onSetUp = true;
    public override void Initialize(CompanionStateMachine owner)
    {
        companionAnimator = owner.GetComponentInChildren<Animator>();
        this.owner = (Companion)owner;
        companionHandler = owner.GetComponent<CompanionHandler>();
        compaionRB = owner.GetComponent<Rigidbody>();
        thisAgent = owner.GetComponent<NavMeshAgent>();

    }



    public override void Enter()
    {
        characterModel = owner.transform.Find("Idle");
        base.Enter();
        //Debug.Log("enter BaseState Companion");

    }


    public override void HandleUpdate()
    {

        if (onSetUp)
        {
            owner.Transition<CompanionIdelState>();

            onSetUp = false;
        }
        
        // OM SPELAREN ÄR 3M IFRÅN I Y-LED SÅ GÅR DEN IN I IDEL 

        //if(Vector3.Distance(thisAgent.transform.position, new Vector3( thisAgent.transform.position.x, ObjectHandeler.Player.transform.position.y,thisAgent.transform.position.z)) > 3)
        //{
        //    owner.Transition<CompanionIdelState>();
        //}

        CheckIfWaiting();

    }

    private void CheckIfWaiting()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (owner.gameObject.CompareTag("Set"))
            {
                if (owner.isWaiting == false)
                {
                    companionHandler.SpeechBubble("I'll stay here, I guess...", "Set");
                    owner.Transition<CompanionWaitingState>();

                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (owner.gameObject.CompareTag("Alice"))
            {
                if (owner.isWaiting == false)
                {
                    companionHandler.SpeechBubble("I'll stop here.", "Alice");
                    owner.Transition<CompanionWaitingState>();
                }
            }
        }
    }
}
