using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MonsterLevelOneScrpit : MonoBehaviour
{
   /*[HideInInspector]*/ public bool isChasing = false;
    private bool isStopped = false;
    private DeathComponent deathComponent;
    private NavMeshAgent agent;
    [SerializeField] private GameObject player;
    private DeathComponent dc;
    private Transform playerTrans;
    [SerializeField] private Transform stopPoint;
    private Vector3 originalPosition = Vector3.zero;

    private void Start()
    {
        playerTrans = player.transform;
        dc = player.GetComponent<DeathComponent>();
        agent = GetComponent<NavMeshAgent>();
        //deathComponent = GetComponent<DeathComponent>();
        originalPosition = this.transform.position;
    }

    private void Update()
    {
        if(isStopped == false)
        {
            if (isChasing == true)
            {
                setMonsterDestination(playerTrans);
            }
        }

        if(checkDistanceToStopPoint() < 1.5f)
        {
            agent.isStopped = true;
            transform.LookAt(playerTrans);
            isStopped = true;
            isChasing = false;
        }
        

    }

    private void RespawnMonster()
    {
        Debug.Log("Warp");
        isChasing = false;
        agent.Warp(originalPosition);
        transform.position = originalPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isChasing = false;
            dc.RespawnPlayer();
            RespawnMonster();
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
