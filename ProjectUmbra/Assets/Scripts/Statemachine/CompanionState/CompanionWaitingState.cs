using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "Companion/WaitingState")]

public class CompanionWaitingState : CompanionBaseState
{

    //private bool isWalkingToButton = false;

    private Transform buttonTrans;
    

    public override void Enter()
    {
        
        //thisAgent.path.ClearCorners();

        Debug.Log(owner.gameObject.name + " enter Waiting state");
        owner.iconSprite.color = new Color(0f, 0f, 0f, 1f);
        
        owner.isWaiting = true;


        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach(GameObject button in buttons)
        {
            Debug.Log(button.name + " " + button.transform.position);
            if(Vector3.Distance(owner.transform.position, button.transform.position)  < 5)
            {
                
                buttonTrans = button.transform;
                owner.isWalkingToButton = true;

                owner.GetComponent<NavMeshAgent>().SetDestination(new Vector3(button.transform.position.x, owner.transform.position.y, button.transform.position.z));
                Debug.Log( Vector3.Distance(owner.transform.position, button.transform.position) + " " + thisAgent.pathStatus + thisAgent.isStopped + " " + thisAgent.pathEndPosition);

                thisAgent.isStopped = false;


            }

        }
        
   

    }

    private void StopAgent()
    {
        thisAgent.isStopped = true;

    }

    public override void HandleUpdate()
    {
        if (owner.isWalkingToButton)
        {
            //thisAgent.SetDestination(buttonTrans.position);
            Debug.Log(thisAgent.pathEndPosition);

            //thisAgent.SetDestination(new Vector3( buttonTrans.transform.position.x, owner.transform.position.y, buttonTrans.transform.position.z));
            if (Vector3.Distance(owner.transform.position, buttonTrans.position) < 0.5f)
            {
                StopAgent();
                owner.isWalkingToButton = false;
            }
        }


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
                    //thisAgent.isStopped = false;
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
