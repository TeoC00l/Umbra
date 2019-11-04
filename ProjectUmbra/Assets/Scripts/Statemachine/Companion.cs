using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Companion : CompanionStateMachine
{
    [SerializeField] public GameObject TargetPlayer;
    public bool isWaiting = false;
    public bool isWalkingToButton;
    public Image iconSprite;

}
