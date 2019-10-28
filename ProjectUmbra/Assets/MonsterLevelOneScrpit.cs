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
    [SerializeField] private Transform playerTrans;
    [SerializeField] private Transform stopPoint;
    

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        deathComponent = GetComponent<DeathComponent>();
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            deathComponent.RespawnPlayer();
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
