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
}
