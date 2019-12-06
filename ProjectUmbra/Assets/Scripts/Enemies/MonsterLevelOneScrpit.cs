﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MonsterLevelOneScrpit : MonoBehaviour
{
    private Animator animator;
    public bool isChasing = false;
    private bool isStopped = false;
    private DeathComponent deathComponent;
    private NavMeshAgent agent;
    [SerializeField] private GameObject chaseColliderGO;
    private GameObject playerGO;
    //private DeathComponent dc;
    private Transform playerTrans;
    [SerializeField] private Transform stopPoint;
    public Vector3 originalPosition;

    private void Awake()
    {

        playerGO = GameObject.FindGameObjectWithTag("Player");
        //Debug.Log(playerGO.name);
    }

    private void Start()
    {
        
        animator = GetComponentInChildren<Animator>();
        playerTrans = playerGO.transform;
        agent = GetComponent<NavMeshAgent>();
        deathComponent = playerGO.GetComponent<DeathComponent>();
        originalPosition = transform.position;    
    }

    private void Update()
    {
        if(playerGO == null)
        {
            playerGO = ObjectHandeler.Player;
        }

        if (isChasing == true)
        {
            
            setMonsterDestination(playerTrans);

            animator.SetBool("isChasing", true);
            agent.isStopped = false;

            
          
        }

        IfCloseToStopPosition();

        if (deathComponent.IsDying == true && transform.position != originalPosition)
        {
            RespawnMonster();
        }


    }

    private void IfCloseToStopPosition()
    {
        if (Vector3.Distance(transform.position, stopPoint.position) < 3.5f)
        {
            foreach (GameObject monster in chaseColliderGO.GetComponent<ChasePlayer>().monsters)
            {
                monster.GetComponent<NavMeshAgent>().isStopped = true;

                monster.GetComponent<MonsterLevelOneScrpit>().isChasing = false;
                animator.SetBool("isChasing", false);


            }

        }
    }

    public void RespawnMonster()
    {
        
        foreach (GameObject monster in chaseColliderGO.GetComponent<ChasePlayer>().monsters)
        {
            NavMeshAgent thisAgent = monster.GetComponent<NavMeshAgent>();
            thisAgent.Warp(monster.GetComponent<MonsterLevelOneScrpit>().originalPosition);

            monster.GetComponent<MonsterLevelOneScrpit>().isChasing = false;
            animator.SetBool("isChasing", false);
            monster.GetComponent<NavMeshAgent>().isStopped = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Set") || other.CompareTag("Alice"))
        //{
        //    Physics.IgnoreCollision(GetComponent<BoxCollider>(), other.GetComponent<BoxCollider>());
        //}

        if (other.CompareTag("Player"))
        {
            deathComponent.RespawnPlayer();
            RespawnMonster();
            AudioManager.instance.Play("MonsterGrowl");
        }
    }

    public void setMonsterDestination(Transform playerTrans)
    {
        agent.SetDestination(playerTrans.position);
    }

    private float checkDistanceToStopPoint()
    {
        return Vector3.Distance(transform.position, stopPoint.position);
    }


}
