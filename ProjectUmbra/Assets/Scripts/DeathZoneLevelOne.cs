using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneLevelOne : MonoBehaviour
{

   [SerializeField] private DeathComponent deathComponent;


    private void OnTriggerEnter(Collider other)
    {
        deathComponent.RespawnPlayer();

        MonsterLevelOneScrpit.RespawnMonster();

    }
}
