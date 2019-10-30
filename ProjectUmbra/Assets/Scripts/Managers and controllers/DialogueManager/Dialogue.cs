using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string name;
    private bool hasBeenPlayed = false;

    [TextArea(3,10)]
    public string[] sentences;

    public void HasBeenPlayed(bool status)
    {
        hasBeenPlayed = status;
    }

    public bool getPlayedStatus()
    {
        return hasBeenPlayed;
    }
}
