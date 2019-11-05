﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DeathComponent : MonoBehaviour
{
    [SerializeField] private int fallDistanceToDie;
    [SerializeField] private GameObject set, alice;

    private PlayerMovement pm;
    private bool cachedGroundedPos, hasCalculatedAirDistance;
    public static Vector3 cachedPosition;
    public static float fallDistance;
    [SerializeField] private CheckPointManager checkpointManager;

    private GameObject groundChecker;
    [SerializeField] private LayerMask deathZone;

    [SerializeField] private DeathscreenTimer deathScreenTimer;
    


    // Start is called before the first frame update
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
        groundChecker = transform.GetChild(0).gameObject;
    }


    private void Update()
    {
        FallDistanceCheck();
        
    }
    

    private void FallDistanceCheck()
    {
        if (pm.IsGrounded() == false)
        {
            hasCalculatedAirDistance = false;
            if (cachedGroundedPos == false)
            {
                cachedPosition = gameObject.transform.position;
                cachedGroundedPos = true;
            }
        }
        else
        {
            if (hasCalculatedAirDistance == false)
            {

                fallDistance = cachedPosition.y - gameObject.transform.position.y;
                if (fallDistance > fallDistanceToDie)
                {
                    //Debug.Log(fallDistance + " fall distance");
                    //die here
                    RespawnPlayer();
                    //gameObject.SetActive(false);
                }
                fallDistance = 0;
                cachedGroundedPos = false;
                hasCalculatedAirDistance = true;
            }
        }
    }

    public void RespawnPlayer()
    {
        //Debug.Log("respawning");
        deathScreenTimer.startFade();
        StartCoroutine(Respawn());
        //Transform respawnPosition = checkpointManager.GetLatestCheckpointPosition();
        //transform.position = respawnPosition.position;
        ////transform.rotation = checkpointManager.GetPlayerRotationAtCheckpoint();
        //try { 
        //    set.GetComponent<NavMeshAgent>().Warp(respawnPosition.position);
        //    alice.GetComponent<NavMeshAgent>().Warp(respawnPosition.position);
        //}
        //catch (UnassignedReferenceException)
        //{

        //}
    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(0.8f);
        Transform respawnPosition = checkpointManager.GetLatestCheckpointPosition();
        transform.position = respawnPosition.position;
        //transform.rotation = checkpointManager.GetPlayerRotationAtCheckpoint();
        try
        {
            set.GetComponent<NavMeshAgent>().Warp(respawnPosition.position);
            alice.GetComponent<NavMeshAgent>().Warp(respawnPosition.position);
        }
        catch (UnassignedReferenceException)
        {

        }
    }

}