using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class KarmaManager
{

    private static int karmaPoints = 0;

    public static int Karma
    {
        get
        {
            return karmaPoints;
        }
        set
        {
            karmaPoints += value;
            Debug.Log("Karma: " + Karma);
        }
    }

}
