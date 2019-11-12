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



    private bool onSetUp = true;
    public override void Initialize(CompanionStateMachine owner)
    {
        this.owner = (Companion)owner;
        companionHandler = owner.GetComponent<CompanionHandler>();
        compaionRB = owner.GetComponent<Rigidbody>();
        thisAgent = owner.GetComponent<NavMeshAgent>();

    }



    public override void Enter()
    {
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
            if (owner.gameObject.name == "Set")
            {
                if (owner.isWaiting == false)
                {
                    
                    owner.Transition<CompanionWaitingState>();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (owner.gameObject.name == "Alice")
            {
                if (owner.isWaiting == false)
                {
                    owner.Transition<CompanionWaitingState>();
                }
            }
        }
    }
}
