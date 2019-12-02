using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    //public float[] latestPassedCheckpoint;
    public int currentKarma;
    public int lastLoadedSceneIndex;

    public PlayerData(CheckPointManager cpm)
    {
        currentKarma = KarmaManager.Karma;
        lastLoadedSceneIndex = SceneManager.GetActiveScene().buildIndex;

        //latestPassedCheckpoint = new float[3];
        //latestPassedCheckpoint[0] = cpm.GetLatestCheckpointPosition().position.x;
        //latestPassedCheckpoint[1] = cpm.GetLatestCheckpointPosition().position.y;
        //latestPassedCheckpoint[2] = cpm.GetLatestCheckpointPosition().position.z;
    }
}
