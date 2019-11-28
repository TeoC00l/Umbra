using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{

    private Vector3 spawnLocation;


    private void Awake()
    {
        spawnLocation = transform.position;
    }


    public void RespawnBox()
    {
        transform.position = spawnLocation + new Vector3(0, 1, 0);
    }
}
