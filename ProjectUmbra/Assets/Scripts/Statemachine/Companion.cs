using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companion : CompanionStateMachine
{
    [SerializeField] public GameObject TargetPlayer;
    public bool isWaiting = false;
    public bool isWalkingToButton;


}
