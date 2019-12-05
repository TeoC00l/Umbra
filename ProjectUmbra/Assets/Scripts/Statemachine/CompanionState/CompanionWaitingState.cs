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

        owner.iconSprite.color = new Color(0f, 0f, 0f, 1f);

        owner.isWaiting = true;

        GetNearestButton();

        if (distance < 15)
        {
            owner.isWalkingToButton = true;

            if(buttonTrans.TryGetComponent(out PressurePadMultipleBoolsChild pressurePadMultipleBoolsChild))
            {
                pressurePadMultipleBoolsChild.isOccupied = true;
            }
            else if(buttonTrans.TryGetComponent(out PressurePadTrigger pressurePadTrigger))
            {
                pressurePadTrigger.isOccupied = true;
            }

            owner.GetComponent<NavMeshAgent>().SetDestination(new Vector3(buttonTrans.transform.position.x, owner.transform.position.y, buttonTrans.transform.position.z));
            thisAgent.isStopped = false;

            if (thisAgent.pathStatus == NavMeshPathStatus.PathPartial)
            {
                StopAgent();
                companionAnimator.SetBool("IsWalking", false);
            }
        }

    }

    private void GetNearestButton()
    {
        foreach (GameObject button in ObjectHandeler.ButtonList)
        {
            tempDistance = Vector3.Distance(owner.transform.position, button.transform.position);
            if(button.TryGetComponent(out PressurePadMultipleBoolsChild pressurePadWithMultipleBoolsChild))
            {
                if (tempDistance < distance && pressurePadWithMultipleBoolsChild.isOccupied == false)
                {
                    distance = tempDistance;

                    buttonTrans = button.transform;
                }
            }

            if(button.TryGetComponent(out PressurePadTrigger pressurePadTrigger))
            {
                if (tempDistance < distance && pressurePadTrigger.isOccupied == false)
                {
                    distance = tempDistance;
                    buttonTrans = button.transform;
                }

            }

        }
    }

    public override void HandleUpdate()
    {
        if (owner.isWalkingToButton)
        {
            companionAnimator.SetBool("IsWalking", true);


            if (Vector3.Distance(owner.transform.position, buttonTrans.position) < 0.25f)
            {
                StopAgent();
                owner.isWalkingToButton = false;
                companionAnimator.SetBool("IsWalking", false);

            }

            //if (Vector3.Distance(owner.transform.position, buttonTrans.position) < 0.5f)
            //{
            //    StopAgent();
            //    owner.isWalkingToButton = false;
            //}
        }

        CheckIfNotWaiting();

        StopWalkingAnimationIfNotMoving();
    }

    private void StopWalkingAnimationIfNotMoving()
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
        if(!(owner.TargetPlayer.GetComponent<PlayerMovement>().getSpeed() == 0))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (owner.gameObject.CompareTag("Set"))
                {
                    if (owner.isWaiting == true)
                    {
                        owner.isWaiting = false;
                        if (buttonTrans.TryGetComponent(out PressurePadMultipleBoolsChild pressurePadMultipleBoolsChild))
                        {
                            pressurePadMultipleBoolsChild.isOccupied = false;
                        }
                        else if (buttonTrans.TryGetComponent(out PressurePadTrigger pressurePadTrigger))
                        {
                            pressurePadTrigger.isOccupied = false;
                        }
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
                        if(buttonTrans.TryGetComponent(out PressurePadMultipleBoolsChild pressurePadMultipleBoolsChild))
                        {
                            pressurePadMultipleBoolsChild.isOccupied = false;
                        }else if(buttonTrans.TryGetComponent(out PressurePadTrigger pressurePadTrigger))
                        {
                            pressurePadTrigger.isOccupied = false;
                        }
                        owner.isWaiting = false;
                        owner.Transition<CompanionIdelState>();

                        companionHandler.SpeechBubble("I'll get moving!", "Alice");
                    }
                }
            }
        }
    }
}
