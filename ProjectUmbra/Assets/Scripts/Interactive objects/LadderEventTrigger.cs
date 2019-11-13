using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class LadderEventTrigger : MonoBehaviour
{

    [SerializeField] private GameObject otherTrigger;
    [SerializeField] private GameObject LadderSplineGO;
    [SerializeField] private Spline LadderSpline;
    [SerializeField] private bool isHigh;



    private void ClimbLadderEventMethod()
    {
        enterSetClimb();
        Invoke("enterAliceClimb", 0.5f);
        changeLadderTrigger();
    }


    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
            
            if (other.CompareTag("Player"))
        {
            ClimbLadderEventMethod();
        }
    }

    private void enterAliceClimb()
    {
        ObjectHandeler.Alice.GetComponent<Companion>().LadderSplineGO = this.LadderSplineGO;
        ObjectHandeler.Alice.GetComponent<Companion>().isHighLadder = this.isHigh;
        ObjectHandeler.Alice.GetComponent<Companion>().LadderSpline = this.LadderSpline;

        if (ObjectHandeler.Alice.GetComponent<Companion>().GetCurrentCompanionState() is CompanionWaitingState   /*Equals(typeof(CompanionWaitingState)) == false*/){

            Debug.Log(ObjectHandeler.Alice.GetComponent<Companion>().GetCurrentCompanionState() + "is in WaitingState");


        }
        else
        {
            ObjectHandeler.Alice.GetComponent<Companion>().Transition<CompanionClimbLadderState>();
        }

    }

    private void enterSetClimb()
    {
        ObjectHandeler.Set.GetComponent<Companion>().LadderSplineGO = this.LadderSplineGO;
        ObjectHandeler.Set.GetComponent<Companion>().isHighLadder = this.isHigh;
        ObjectHandeler.Set.GetComponent<Companion>().LadderSpline = this.LadderSpline;

        if(ObjectHandeler.Set.GetComponent<Companion>().GetCurrentCompanionState() is CompanionWaitingState)
        {
            Debug.Log(ObjectHandeler.Set.GetComponent<Companion>().GetCurrentCompanionState() + "is in WaitingState");

        }
        else
        {
            ObjectHandeler.Set.GetComponent<Companion>().Transition<CompanionClimbLadderState>();
        }


    }

    private void changeLadderTrigger()
    {
        otherTrigger.SetActive(true);
        gameObject.SetActive(false);
    }
  
}
