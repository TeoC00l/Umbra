using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    //private Transform checkpointPosition;
    //[SerializeField] private Transform[] checkpointPositionsArray;
    //private float currentCheckpoint = 0;
    private Transform currentCheckpointPosition;
    private Quaternion latestRotation;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void UpdateCurrentCheckpoint(Transform checkpointPosition, Quaternion playerRotation)
    {
        //currentCheckpoint++;
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
