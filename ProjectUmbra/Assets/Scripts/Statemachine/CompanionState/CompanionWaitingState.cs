using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Companion/WaitingState")]

public class CompanionWaitingState : CompanionBaseState
{

    public override void Enter()
    {
        Debug.Log(owner.gameObject.name + " enter Waiting state");
        owner.isWaiting = true;
        agent.isStopped = true;
    }

    public override void HandleUpdate()
    {
        CheckIfNotWaiting();

    }

    private void CheckIfNotWaiting()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (owner.gameObject.name == "Set")
            {
                if (owner.isWaiting == true)
                {
                    owner.isWaiting = false;
                    owner.Transition<CompanionIdelState>();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (owner.gameObject.name == "Alice")
            {
                if (owner.isWaiting == true)
                {
                    owner.isWaiting = false;
                    owner.Transition<CompanionIdelState>();
                }
            }
        }
    }
}
