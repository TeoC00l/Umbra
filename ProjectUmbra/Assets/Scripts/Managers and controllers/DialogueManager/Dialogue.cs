using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    public string name;
    private bool hasBeenPlayed = false;
    public Sprite characterImage;
    [SerializeField] private bool playNextVideo = false;
    public string changeToScene = "";

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
