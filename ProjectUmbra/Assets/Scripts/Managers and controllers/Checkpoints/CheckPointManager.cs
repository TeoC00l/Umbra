using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    [SerializeField] private Transform currentCheckpointPosition;
    private Quaternion latestRotation;

    public void UpdateCurrentCheckpoint(Transform checkpointPosition, Quaternion playerRotation)
    {
        latestRotation = playerRotation;
        currentCheckpointPosition = checkpointPosition;
    }

    public Transform GetLatestCheckpointPosition()
    {
        return currentCheckpointPosition;
    }

    public Quaternion GetPlayerRotationAtCheckpoint()
    {
        return latestRotation;
    }
}
