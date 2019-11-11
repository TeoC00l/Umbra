using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class LadderEventTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject set;
    public GameObject LadderSplineGO;
    public Spline LadderSpline;


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
            Debug.Log("p found");
            set.GetComponent<Companion>().LadderSplineGO = this.LadderSplineGO;
            set.GetComponent<Companion>().LadderSpline = this.LadderSpline;
            set.GetComponent<Companion>().Transition<CompanionClimbLadderState>();
    }
}
