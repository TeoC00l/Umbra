using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void CompanionClimbDelegate();
    public static event CompanionClimbDelegate onClimbLadderEvent;

    public static void ClimbLadderEvent()
    {
        if (onClimbLadderEvent != null)
        {
            onClimbLadderEvent();
        }
    }
}
