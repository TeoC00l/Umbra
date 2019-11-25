using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "Companion/WaitingState")]

public class CompanionWaitingState : CompanionBaseState
{

    //private bool isWalkingToButton = false;

    private Transform buttonTrans;
    private float distance;
    private float tempDistance;

    public override void Enter()
    {
        distance = Mathf.Infinity;
        //thisAgent.path.ClearCorners();

        //Debug.Log(owner.gameObject.name + " enter Waiting state");
        owner.iconSprite.color = new Color(0f, 0f, 0f, 1f);

        owner.isWaiting = true;


        foreach (GameObject button in ObjectHandeler.ButtonList)
        {
            tempDistance = Vector3.Distance(owner.transform.position, button.transform.position);

            if (tempDistance < distance && button.GetComponent<PressurePadMultipleBoolsChild>().isOccupied == false)
            {
                distance = tempDistance;

                buttonTrans = button.transform;
            }



        }

        if (distance < 15)
        {
            owner.isWalkingToButton = true;

            buttonTrans.GetComponent<PressurePadMultipleBoolsChild>().isOccupied = true;
            owner.GetComponent<NavMeshAgent>().SetDestination(new Vector3(buttonTrans.transform.position.x, owner.transform.position.y, buttonTrans.transform.position.z));
            thisAgent.isStopped = false;

            if (thisAgent.pathStatus == NavMeshPathStatus.PathPartial)
            {
                StopAgent();
                companionAnimator.SetBool("IsWalking", false);
            }

            //Debug.Log(Vector3.Distance(owner.transform.position, buttonTrans.transform.position) + " " + thisAgent.pathStatus + thisAgent.isStopped + " " + thisAgent.pathEndPosition);
        }
        else
        {
        }
    }


    public override void HandleUpdate()
    {
        if (owner.isWalkingToButton)
        {
            companionAnimator.SetBool("IsWalking", true);

            //thisAgent.SetDestination(buttonTrans.position);
            //Debug.Log(thisAgent.pathEndPosition);

            //thisAgent.SetDestination(new Vector3( buttonTrans.transform.position.x, owner.transform.position.y, buttonTrans.transform.position.z));
            if (Vector3.Distance(owner.transform.position, buttonTrans.position) < 0.25f)
            {
                StopAgent();
                owner.isWalkingToButton = false;
            }

            if (Vector3.Distance(owner.transform.position, buttonTrans.position) < 0.5f)
            {
                StopAgent();
                owner.isWalkingToButton = false;
                companionAnimator.SetBool("IsWalking", false);
            }
        }
        CheckIfNotWaiting();

        StopWalkingIfNotMoving();
    }

    private void StopWalkingIfNotMoving()
    {
        if (thisAgent.velocity.magnitude < 1)
        {
            companionAnimator.SetBool("IsWalking", false);

        }
    }

    private void StopAgent()
    {
        companionAnimator.SetBool("IsWalking", false);
        thisAgent.isStopped = true;
        owner.isWaiting = true;
        
    }



    private void CheckIfNotWaiting()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (owner.gameObject.CompareTag("Set"))
            {
                if (owner.isWaiting == true)
                {
                    owner.isWaiting = false;
                    buttonTrans.GetComponent<PressurePadMultipleBoolsChild>().isOccupied = false;
                    owner.Transition<CompanionIdelState>();
                    companionHandler.SpeechBubble("Going...", "Set");
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (owner.gameObject.CompareTag("Alice"))
            {
                if (owner.isWaiting == true)
                {
                    buttonTrans.GetComponent<PressurePadMultipleBoolsChild>().isOccupied = false;

                    owner.isWaiting = false;
                    owner.Transition<CompanionIdelState>();

                    companionHandler.SpeechBubble("I'll get moving!", "Alice");
                }
            }
        }
    }
}
