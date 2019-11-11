using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CheckPoint : MonoBehaviour
{

    [SerializeField] private CheckPointManager checkpointManager;
    private bool triggered = false;
    private Quaternion playerRotationOnEntry;
    private CinemachineTrackedDolly dollyCamera;
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    private float cameraPosition;
    private GameObject latestCornerTurned;

    private void Start()
    {
        dollyCamera = virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            latestCornerTurned = other.GetComponent<PlayerMovement>().cornerTurner;
            playerRotationOnEntry = other.gameObject.transform.rotation;
            cameraPosition = dollyCamera.m_PathPosition;
            checkpointManager.UpdateCurrentCheckpoint(transform, playerRotationOnEntry, cameraPosition, latestCornerTurned);
            triggered = true;
        }
    }
}
