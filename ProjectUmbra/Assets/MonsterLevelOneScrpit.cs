using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MonsterLevelOneScrpit : MonoBehaviour
{
    /*[HideInInspector]*/
    public bool isChasing = false;
    private bool isStopped = false;
    private DeathComponent deathComponent;
    private NavMeshAgent agent;
    [SerializeField] private GameObject player;
    //private DeathComponent dc;
    private Transform playerTrans;
    [SerializeField] private Transform stopPoint;
    public Vector3 originalPosition;
    //private ChasePlayer chasePlayer;

    private void Start()
    {


        playerTrans = player.transform;
        //dc = player.GetComponent<DeathComponent>();
        agent = GetComponent<NavMeshAgent>();
        deathComponent = player.GetComponent<DeathComponent>();
        //chasePlayer = GetComponentInParent<ChasePlayer>();
        originalPosition = transform.position;
    }

    private void Update()
    {
        if (isChasing == true)
        {

            setMonsterDestination(playerTrans);

            if (agent.pathStatus == NavMeshPathStatus.PathInvalid || agent.pathStatus == NavMeshPathStatus.PathPartial)
            {
                agent.isStopped = true;
            }
        }

        if (Vector3.Distance(transform.position, stopPoint.position) < 3.5f)
        {
            foreach (GameObject monster in ChasePlayer.monsters)
            {
                monster.GetComponent<NavMeshAgent>().isStopped = true; ;

                monster.GetComponent<MonsterLevelOneScrpit>().isChasing = false;

            }

        }


    }

    public static void RespawnMonster()
    {
        Debug.Log("Warp");
        foreach (GameObject monster in ChasePlayer.monsters)
        {
            NavMeshAgent thisAgent = monster.GetComponent<NavMeshAgent>();
            thisAgent.Warp(monster.GetComponent<MonsterLevelOneScrpit>().originalPosition);

            monster.GetComponent<MonsterLevelOneScrpit>().isChasing = false;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Set") || other.CompareTag("Alice"))
        {
            Physics.IgnoreCollision(GetComponent<BoxCollider>(), other.GetComponent<BoxCollider>());
        }

        if (other.CompareTag("Player"))
        {
            deathComponent.RespawnPlayer();
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
