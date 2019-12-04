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
                //monster.TryGetComponent<MonsterLevelOneScrpit>().isChasing = true;
                if(monster.TryGetComponent(out MonsterLevelOneScrpit monsterLevelOneScript))
                {
                    monsterLevelOneScript.isChasing = true;
                }
                if(monster.TryGetComponent(out PuzzelMonster puzzelMonster))
                {
                    puzzelMonster.isChasing = true;
                }
                //monster.TryGetComponent<PuzzelMonster>()
            }
        }
    }






    

}
