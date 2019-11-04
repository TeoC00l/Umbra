using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ChasePlayer : MonoBehaviour
{
    [SerializeField] public static GameObject [] monsters;
    private BoxCollider collider1;


    private void Start()
    {
        monsters = GameObject.FindGameObjectsWithTag("Monster");

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
                    
            foreach (GameObject monster in monsters)
            {
                monster.GetComponent<MonsterLevelOneScrpit>().isChasing = true;
            }
        }
    }






    

}
