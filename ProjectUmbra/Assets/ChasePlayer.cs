using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ChasePlayer : MonoBehaviour
{
    [SerializeField] protected GameObject [] monsters;
    protected bool chasePlayer = false;
    [SerializeField] private Transform chasePoint;
    private Vector3 direction;
    private GameObject targetPlayer;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            chasePlayer = true;
            targetPlayer = other.gameObject;
            foreach (GameObject monster in monsters)
            {
                monster.GetComponent<NavMeshAgent>().SetDestination(chasePoint.position);
            }
        }
    }


    private void Update()
    {

        if (chasePlayer == true)
        {
            foreach (GameObject monster in monsters)
            {

                if (Vector3.Distance(monster.transform.position, chasePoint.position) < 1)
                {
                    monster.GetComponent<NavMeshAgent>().isStopped = true;

                    monster.transform.LookAt(targetPlayer.transform,Vector3.up);
                }
            }
        }
        
    }

    private void setDirection(GameObject follower)
    {
        direction = targetPlayer.transform.position - follower.transform.position;
        direction.Normalize();
    }
}
