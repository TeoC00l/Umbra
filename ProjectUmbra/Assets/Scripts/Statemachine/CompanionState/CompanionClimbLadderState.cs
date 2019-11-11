using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Pixelplacement;

[CreateAssetMenu(menuName = "Companion/ClimbLadderState")]
public class CompanionClimbLadderState : CompanionBaseState
{
    bool isTween = false;
    private Vector3 splinePos;

    public override void Enter()
    {
        if(owner.name == "Set")
        {
            Debug.Log("Set Entered climb");
            
        }

        thisAgent.radius = 0.1f;

        Debug.Log("entered");
        thisAgent.SetDestination(owner.LadderSplineGO.transform.position);
        //owner.GetComponent<NavMeshAgent>().enabled = false;
        //owner.transform.position = owner.LadderSplineGO.transform.position;
        Debug.Log("anchor dest set");
        splinePos = new Vector3(owner.LadderSplineGO.transform.position.x, owner.transform.position.y, owner.LadderSplineGO.transform.position.z);

    }

    public override void HandleUpdate()
    {
        if(thisAgent.pathStatus == NavMeshPathStatus.PathInvalid || thisAgent.pathStatus == NavMeshPathStatus.PathPartial)
        {
            owner.Transition<CompanionIdelState>();
        }

        if (Vector3.Distance(splinePos,  owner.transform.position) < 0.5f)
        {
            Debug.Log("close to anchor");

            owner.GetComponent<NavMeshAgent>().enabled = false;
            if (!isTween)
            {
                if (owner.isHighLadder)
                {
                    Tween.Spline(owner.LadderSpline, owner.transform, 0f, 1f, false, 1f, 0f, Tween.EaseInOut, Tween.LoopType.None, null, OnTweenFinished);
                    Debug.Log("do spline?");
                    isTween = true;
                }
                else
                {
                    Tween.Spline(owner.LadderSpline, owner.transform, 1f, 0f, false, 1f, 0f, Tween.EaseInOut, Tween.LoopType.None, null, OnTweenFinished);
                    Debug.Log("do spline?");
                    isTween = true;
                }

                
            }
        }
        else
        {
            thisAgent.SetDestination(owner.LadderSplineGO.transform.position);
        }
        
    }

    public override void Exit()
    {
        thisAgent.radius = 0.5f;

    }


    private void OnTweenFinished()
    {
        isTween = false;
        owner.GetComponent<NavMeshAgent>().enabled = true;
        owner.Transition<CompanionWalkState>();
    }

}
