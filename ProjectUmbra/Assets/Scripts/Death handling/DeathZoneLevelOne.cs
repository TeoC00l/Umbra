﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneLevelOne : MonoBehaviour
{

   [SerializeField] private DeathComponent deathComponent;
    private MonsterLevelOneScrpit monsterLevelOneScrpit;
    private void Start()
    {
        monsterLevelOneScrpit = GetComponent<MonsterLevelOneScrpit>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            deathComponent.RespawnPlayer();
            try
            {
                monsterLevelOneScrpit.RespawnMonster();
            }
            catch (System.NullReferenceException)
            {

            }
        }
        
    }
}