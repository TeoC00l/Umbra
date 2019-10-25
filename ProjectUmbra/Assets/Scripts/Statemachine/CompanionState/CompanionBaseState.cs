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
    protected NavMeshAgent agent;

    public override void Initialize(CompanionStateMachine owner)
    {
        this.owner = (Companion)owner;
        companionHandler = owner.GetComponent<CompanionHandler>();
        compaionRB = owner.GetComponent<Rigidbody>();
        agent = owner.GetComponent<NavMeshAgent>();

    }



    public override void Enter()
    {
        base.Enter();
        Debug.Log("enter BaseState Companion");


    }


    public override void HandleUpdate()
    {
        owner.Transition<CompanionIdelState>();

    }

}
