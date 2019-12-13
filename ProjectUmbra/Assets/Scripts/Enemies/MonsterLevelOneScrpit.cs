using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MonsterLevelOneScrpit : MonoBehaviour
{


    public bool isChasing = false;
    private bool isStopped = false;
    private DeathComponent deathComponent;
    private NavMeshAgent agent;
    [SerializeField] private GameObject chaseColliderGO;
    private GameObject playerGO;
    //private DeathComponent dc;
    private Transform playerTrans;

    [SerializeField] private Transform stopPoint;
    [HideInInspector]
    public Vector3 originalPosition;
    [HideInInspector]
    public Animator animator;
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

        //if (deathComponent.IsDying == true)
        //{
        //    RespawnMonster();
        //}
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

            monster.GetComponent<MonsterLevelOneScrpit>().StartCoroutine(RespawnMonsters());
            //StartCoroutine(monster.GetComponent<MonsterLevelOneScrpit>().RespawnMonsters());            

        }

    }

    //public void startRespawn()
    //{
    //    StartCoroutine(RespawnMonsters());
    //}
    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Set") || other.CompareTag("Alice"))
        //{
        //    Physics.IgnoreCollision(GetComponent<BoxCollider>(), other.GetComponent<BoxCollider>());
        //}


        if (other.CompareTag("Player"))
        {
            agent.isStopped = true;
            agent.velocity = Vector3.zero;
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


    public IEnumerator RespawnMonsters(){
        //NavMeshAgent thisAgent = monster.GetComponent<NavMeshAgent>();

        isChasing = false;
        animator.SetBool("isChasing", false);
        agent.isStopped = false;
        yield return new WaitForSeconds(deathComponent.deathDuration);
        agent.Warp(originalPosition);


    }

    //IEnumerable RespawnMonsters()
    //{
    //    NavMeshAgent thisAgent = monster.GetComponent<NavMeshAgent>();

    //    monster.GetComponent<MonsterLevelOneScrpit>().isChasing = false;
    //    monster.GetComponentInChildren<Animator>().SetBool("isChasing", false);
    //    monster.GetComponent<NavMeshAgent>().isStopped = false;
    //    yield return new WaitForSeconds(deathComponent.deathDuration);
    //    thisAgent.Warp(monster.GetComponent<MonsterLevelOneScrpit>().originalPosition);


    //}
}
