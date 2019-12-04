using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PuzzelMonster : MonoBehaviour
{

    private GameObject player;
    private NavMeshAgent agent;
    private Vector3 spawnPosition;
    private DeathComponent deathComponent;
    private Animator animator;

    public bool isChasing = false;

    private void Start()
    {
        player = ObjectHandeler.Player;
        agent = GetComponent<NavMeshAgent>();
        spawnPosition = transform.position;
        deathComponent = player.GetComponent<DeathComponent>();
        animator = GetComponentInChildren<Animator>();

    }



    private void Update()
    {
        if (isChasing == true && ToHighToChase() == false)
        {
            agent.isStopped = false;
            agent.SetDestination(player.transform.position);
            animator.SetBool("isChasing", true);

        }

        if (isChasing == false || ToHighToChase() == true)
        {
            agent.isStopped = true;
            animator.SetBool("isChasing", false);
        }
    }



    private bool ToHighToChase()
    {
        
        if((Vector3.Distance(new Vector3(0, player.transform.position.y, 0) , new Vector3(0, transform.position.y, 0))) > 3f)
        {
            return true;
        }
        return false;
    }


    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))
        {
            deathComponent.RespawnPlayer();
            animator.SetBool("isChasing", false);
            RespawnPuzzelMonster();
            AudioManager.instance.Play("MonsterGrowl");
        }

        
    }

    



    private void RespawnPuzzelMonster()
    {
        isChasing = false;
        agent.isStopped = true;

        agent.Warp(spawnPosition);

    }
}
