using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void CompanionClimbDelegate(GameObject ladder);
    public static event CompanionClimbDelegate onClimbLadderEvent;

    public static void ClimbLadderEvent(GameObject ladder)
    {
        if (onClimbLadderEvent != null)
        {
            onClimbLadderEvent(ladder);
        }
    }
}
