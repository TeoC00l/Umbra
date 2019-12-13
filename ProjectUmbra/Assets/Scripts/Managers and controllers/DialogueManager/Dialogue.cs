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
    [Header("Check if the dialogue is the last in an event or a one-off.")]
    [SerializeField] public bool isFinal = false;

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
