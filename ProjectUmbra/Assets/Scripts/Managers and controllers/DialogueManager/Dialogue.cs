using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string name;
    private bool hasBeenPlayed = false;
    [SerializeField] private bool playNextVideo = false;

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

    public bool getPlayNextVideo()
    {
        return playNextVideo;
    }
}
