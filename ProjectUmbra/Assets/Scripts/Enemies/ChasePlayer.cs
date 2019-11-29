using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ChasePlayer : MonoBehaviour
{
    [SerializeField] public GameObject [] monsters;
    private BoxCollider collider1;


    private void Start()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.instance.Play("MonsterGrowl");
                    
            foreach (GameObject monster in monsters)
            {
                AudioManager.instance.Play("MonsterGrowl");
                monster.GetComponent<MonsterLevelOneScrpit>().isChasing = true;
            }
        }
    }






    

}
