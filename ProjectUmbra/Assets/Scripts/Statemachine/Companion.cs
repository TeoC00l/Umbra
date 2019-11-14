using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pixelplacement;

public class Companion : CompanionStateMachine
{
    [SerializeField] public GameObject TargetPlayer;
    public GameObject LadderSplineGO;
    public bool isWaiting = false;
    public bool isWalkingToButton;
    public Image iconSprite;
    public Spline LadderSpline;
    EventManager eventManager;
    public bool isHighLadder;


    public bool TargetIsToFarInYAxis()
    {
        if(Vector3.Distance(new Vector3(0, transform.position.y,0), new Vector3(0, TargetPlayer.transform.position.y, 0)) > 2){

            //Debug.Log(Vector3.Distance(new Vector3(0, transform.position.y, 0), new Vector3(0, TargetPlayer.transform.position.y, 0)));
            return true;
        }
        return false;
    }



}
