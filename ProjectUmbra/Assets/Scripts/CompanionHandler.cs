using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CompanionHandler : MonoBehaviour
{
    [SerializeField] private GameObject targetPlayer;
    [SerializeField] private float bufferDistanceToPlayer = 5f;
    [SerializeField] private float speed = 5f;

    private Rigidbody setRB;
    private Rigidbody aliceRB;

    private NavMeshAgent setAgent;
    private NavMeshAgent aliceAgent;
    private GameObject Set;
    private GameObject Alice;


    private Vector3 direction;

    private bool setMoving = true;
    private bool aliceMoving = true;

    // Start is called before the first frame update
    void Start()
    {
        Set = GameObject.FindGameObjectWithTag("Set");
        Alice = GameObject.FindGameObjectWithTag("Alice");
        setRB = Set.GetComponent<Rigidbody>();
        aliceRB = Alice.GetComponent<Rigidbody>();
        setAgent = Set.GetComponent<NavMeshAgent>();
        aliceAgent = Alice.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (aliceMoving) {
            setDirection(Alice);
            moveFollower(Alice, aliceAgent);
            checkRotation(Alice);
        }
        if (setMoving)
        {
            setDirection(Set);
            moveFollower(Set, setAgent);
            checkRotation(Set);
        }
        else
        {
            
        }

        setMovement();
    }

    private void setDirection(GameObject follower)
    {
        direction = targetPlayer.transform.position - follower.transform.position;
        direction.Normalize();
    }
    private void moveFollower(GameObject follower, NavMeshAgent agent)
    {
        //rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
        

        if(Vector3.Distance(follower.transform.position, targetPlayer.transform.position) > 5){
            //transform.Translate(direction * speed * Time.fixedDeltaTime);
            agent.SetDestination(targetPlayer.transform.position);

        }
    }

    private void checkRotation(GameObject follower)
    {
        follower.transform.localRotation = targetPlayer.transform.localRotation;
    }
    private void setMovement()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !setMoving && this.CompareTag("Set"))
        {
            setMoving = true;
            setAgent.isStopped = false;
        }
        else if (Input.GetKeyDown(KeyCode.E) && !aliceMoving && this.CompareTag("Alice"))
        {
            aliceMoving = true;
            aliceAgent.isStopped = false;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && setMoving && this.CompareTag("Set"))
        {
            setMoving = false;
            setAgent.isStopped = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && aliceMoving && this.CompareTag("Alice"))
        {
            aliceMoving = false;
            aliceAgent.isStopped = true;
        }
    }
}
