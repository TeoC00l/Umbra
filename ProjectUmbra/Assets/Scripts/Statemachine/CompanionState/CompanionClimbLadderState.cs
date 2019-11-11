using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Pixelplacement;

[CreateAssetMenu(menuName = "Companion/ClimbLadderState")]
public class CompanionClimbLadderState : CompanionBaseState
{

    public override void Enter()
    {
        Debug.Log("entered");
        thisAgent.SetDestination(owner.LadderSpline.transform.position);
    }

    public override void HandleUpdate()
    {
        if (Vector3.Distance(thisAgent.transform.position, owner.LadderSpline.transform.position) < 0.5f)
        {
            owner.GetComponent<NavMeshAgent>().enabled = false;
            Tween.Spline(owner.LadderSpline, owner.transform, 0f, 1f, false, 1f, 0f, Tween.EaseSpring, Tween.LoopType.None);
        }
    }

    public override void Exit()
    {
        
    }

}
