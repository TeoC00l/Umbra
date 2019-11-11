using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class LadderEventTrigger : MonoBehaviour
{
    [SerializeField] private GameObject set;
    [SerializeField] private GameObject alice;
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
        alice = GameObject.FindGameObjectWithTag("Alice");
        set = GameObject.FindGameObjectWithTag("Set");
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
        alice.GetComponent<Companion>().LadderSplineGO = this.LadderSplineGO;
        alice.GetComponent<Companion>().isHighLadder = this.isHigh;
        alice.GetComponent<Companion>().LadderSpline = this.LadderSpline;
        alice.GetComponent<Companion>().Transition<CompanionClimbLadderState>();
    }

    private void enterSetClimb()
    {
        set.GetComponent<Companion>().LadderSplineGO = this.LadderSplineGO;
        set.GetComponent<Companion>().isHighLadder = this.isHigh;
        set.GetComponent<Companion>().LadderSpline = this.LadderSpline;
        set.GetComponent<Companion>().Transition<CompanionClimbLadderState>();
    }

    private void changeLadderTrigger()
    {
        otherTrigger.SetActive(true);
        gameObject.SetActive(false);
    }
  
}
