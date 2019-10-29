using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathComponent : MonoBehaviour
{
    [SerializeField] private int fallDistanceToDie;
    [SerializeField] private GameObject set;
    [SerializeField] private GameObject alice;

    private PlayerMovement pm;
    private bool cachedGroundedPos;
    public Vector3 cachedPosition;
    private bool hasCalculatedAirDistance;
    public float fallDistance;
    [SerializeField] private CheckPointManager checkpointManager;
    
    
    // Start is called before the first frame update
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
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
        Transform respawnPosition = checkpointManager.GetLatestCheckpointPosition();
        transform.position = respawnPosition.position;
        transform.rotation = checkpointManager.GetPlayerRotationAtCheckpoint();
        set.transform.position = respawnPosition.position;
        alice.transform.position = respawnPosition.position;
    }

}
