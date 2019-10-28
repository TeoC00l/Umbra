using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterLevelOneScrpit : MonoBehaviour
{

    public bool hasStopped = false;
    private DeathComponent deathComponent;


    private void Start()
    {
        deathComponent = GetComponent<DeathComponent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //kill player
        }
    }
}
