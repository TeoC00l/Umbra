using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CompanionHandler : MonoBehaviour
{
    [SerializeField] private GameObject targetPlayer;
    [SerializeField] private float bufferDistanceToPlayer = 5f;
    [SerializeField] private float speed = 5f;

    private Rigidbody setRB;
    private Rigidbody aliceRB;

    private NavMeshAgent setAgent;
    private NavMeshAgent aliceAgent;
    [SerializeField] private GameObject Set;
    [SerializeField] private GameObject Alice;


    private Vector3 direction;

    private bool setMoving = true;
    private bool aliceMoving = true;

    

    #region JumpVariabels
    [SerializeField] private float addToJumpHeight = 5;
    private Vector3 startJumpPosition;
    private Vector3 endJumpPosition;

    private float jumpDistance;
    private float maxJumpDistance = 100;

    private NavMeshPath navPath;
    private int endCorenerIndex;
    public bool SetCanJump = false;

    private ReturnNavmeshInfo navInfo;

    private List<Vector3> jumpPath = new List<Vector3>();

    public GameObject agentPrefab;

    public bool isCalced = false;


    #endregion


    private void Start()
    {
        Physics.IgnoreCollision(Set.GetComponent<BoxCollider>(), Alice.GetComponent<BoxCollider>());
    }


    private void Update()
    {
        //IfNotOnNavMesh();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Grabbable"))
        {
            BoxCollider[] colliderArray = collision.gameObject.GetComponents<BoxCollider>();
            Debug.Log(colliderArray.Length);
            foreach (BoxCollider box in colliderArray)
            {
                Physics.IgnoreCollision(box, gameObject.GetComponent<BoxCollider>());
            }
        }
        if (collision.collider.CompareTag("Monster"))
        {
            Physics.IgnoreCollision(collision.collider.GetComponent<BoxCollider>(), gameObject.GetComponent<BoxCollider>());
        }
    }

    private void IfNotOnNavMesh()
    {
        NavMeshAgent thisAgent = gameObject.GetComponent<NavMeshAgent>();
        if (Vector3.Distance(gameObject.transform.position, targetPlayer.transform.position)> 100 )
        {
            Debug.Log("not on mesh");
            Debug.Log(thisAgent.pathStatus);

            thisAgent.Warp(targetPlayer.transform.position);
            thisAgent.SetDestination(targetPlayer.transform.position);
            Debug.Log(thisAgent.pathStatus);

        }
        //else if (thisAgent.pathStatus == NavMeshPathStatus.PathComplete)
        //{
        //    //thisAgent.SetDestination(targetPlayer.transform.position);
        //    //Debug.Log(thisAgent.pathStatus == NavMeshPathStatus.PathComplete);

        //    //Debug.Log("on Mesh");
        //    //gameObject.GetComponent<NavMeshAgent>().Warp(targetPlayer.transform.position);

        //}
    }

    public bool NotCloseToDestinationCheck(NavMeshAgent agent)
    {
        if (Vector3.Distance(agent.transform.position, targetPlayer.transform.position) > 5)
        {

            //Debug.Log("return true dist" + Vector3.Distance(agent.transform.position, targetPlayer.transform.position));
            return true;
        }

        //Debug.Log("return false dist" + Vector3.Distance(agent.transform.position, agent.destination));
        return false;

    }



    private void setDirection(GameObject follower)
    {
        direction = targetPlayer.transform.position - follower.transform.position;
        direction.Normalize();
    }
    private void moveFollower(GameObject follower, NavMeshAgent agent)
    {

        agent.SetDestination(targetPlayer.transform.position);

    }

    private void checkRotation(GameObject follower)
    {
        follower.transform.localRotation = targetPlayer.transform.localRotation;
    }


    private void setMovement()
    {


        if (Input.GetKeyDown(KeyCode.Q) && !setMoving)
        {
            setMoving = true;
            setAgent.isStopped = false;
            Debug.Log("set moving");
        }
        else if (Input.GetKeyDown(KeyCode.E) && !aliceMoving)
        {
            aliceMoving = true;
            aliceAgent.isStopped = false;
            Debug.Log("alice moving");
        }
        else if (Input.GetKeyDown(KeyCode.Q) && setMoving)
        {
            //setIcon.color = new Color(49f, 22f, 41f, 0.56f);
            //setIcon.gameObject.SetActive(false);
            setMoving = false;
            setAgent.isStopped = true;
            Debug.Log("set stopped");
        }
        else if (Input.GetKeyDown(KeyCode.E) && aliceMoving)
        {
            //aliceIcon.color = new Color(49f, 22f, 41f, 0.56f);
            
            aliceMoving = false;
            aliceAgent.isStopped = true;
            Debug.Log("alice stopped");
        }
    }

    public void LateUpdate()
    {
        //characterModel.transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
    }


    // Start is called before the first frame update
    //void Start()
    //{
    //    Set = GameObject.FindGameObjectWithTag("Set");
    //    Alice = GameObject.FindGameObjectWithTag("Alice");
    //    setRB = Set.GetComponent<Rigidbody>();
    //    aliceRB = Alice.GetComponent<Rigidbody>();
    //    setAgent = Set.GetComponent<NavMeshAgent>();
    //    aliceAgent = Alice.GetComponent<NavMeshAgent>();

    //    setAgent.SetDestination(targetPlayer.transform.position);
    //}



    // Update is called once per frame
    //void Update()
    //{





    //    if (aliceMoving) {
    //        setDirection(Alice);
    //        if (NotCloseToDestinationCheck(aliceAgent) == true)
    //        {
    //            aliceAgent.isStopped = false;
    //            moveFollower(Alice, aliceAgent);
    //            //Debug.Log("moveFlollower set");

    //        }
    //        else
    //        {
    //            aliceAgent.isStopped = true;
    //            //Debug.Log("set is stopped");

    //        }
    //        checkRotation(Alice);
    //    }
    //    if (setMoving)
    //    {
    //        setDirection(Set);
    //        if (NotCloseToDestinationCheck(setAgent) == true)
    //        {
    //            setAgent.isStopped = false;
    //            moveFollower(Set, setAgent);
    //            //Debug.Log("moveFlollower set");

    //        }
    //        else
    //        {
    //            setAgent.isStopped = true;
    //            //Debug.Log("set is stopped");

    //        }


    //        checkRotation(Set);
    //    }


    //    setMovement();

    //    //if (setAgent.hasPath)
    //    //{
    //    //    if (setAgent.path.status == NavMeshPathStatus.PathPartial)
    //    //    {
    //    //        MoveToJumpPosition(setAgent);

    //    //        if(SetCanJump == true && isCalced == false)
    //    //        {
    //    //            CalacJumpPath(setAgent);
    //    //            Debug.Log(jumpPath.Count);
    //    //            for (int i = 0; i < jumpPath.Count; i++)
    //    //            {
    //    //                Debug.Log(jumpPath[i]);

    //    //            }
    //    //            isCalced = true;
    //    //        }


    //    //    }
    //    //}

    //}



    //private Vector3 GetStartJumpPosition(NavMeshAgent agent)
    //{
    //    navPath = agent.path;
    //    endCorenerIndex = navPath.corners.Length - 1;
    //    return navPath.corners[endCorenerIndex];
    //}

    //private void MoveToJumpPosition(NavMeshAgent agent)
    //{
    //    if (SetCanJump == false)
    //    {
    //        agent.isStopped = false;
    //        agent.SetDestination(GetStartJumpPosition(agent));
    //    }


    //}
    //private void CalacJumpPath(NavMeshAgent agent)
    //{
    //    jumpPath.Add(startJumpPosition = GetStartJumpPosition(setAgent));
    //    Vector3 midJumpPos = Vector3.Lerp(startJumpPosition, endJumpPosition, 0.5f);
    //    midJumpPos.y = midJumpPos.y + agent.height + addToJumpHeight;
    //    jumpPath.Add(midJumpPos);


    //    GetEndJumpPos();
    //    jumpPath.Add(endJumpPosition);

    //    //for (int i = 0; i < jumpPath.Count; i++)
    //    //{
    //    //    Instantiate<GameObject>(jumpposprefab);
    //    //}
    //    jumpDistance = Vector3.Distance(startJumpPosition, endJumpPosition);
    //    if(jumpDistance <= maxJumpDistance)
    //    {
    //        Jump(agent, agent.gameObject.GetComponent<Rigidbody>());
    //    }
    //    else
    //    {
    //        Debug.Log("To far to jump");
    //    }


    //}

    //private void Jump(NavMeshAgent agent, Rigidbody companionsRB)
    //{
    //    //companionsRB.isKinematic = true;
    //    //agent.enabled = false;

    //    companionsRB.AddForce(new Vector3(0, 5, 5));


    //    //Vector3 targetPosInJump;
    //    //for (int i = 0; i < jumpPath.Count; i++)
    //    //{
    //    //    targetPosInJump = jumpPath[i];
    //    //    if(Vector3.Distance(companionsRB.position, targetPosInJump) > 1)
    //    //    {
    //    //        move
    //    //    }
    //    //}
    //}

    //private void GetEndJumpPos()
    //{
    //    GameObject tmpagent = Instantiate<GameObject>(agentPrefab,targetPlayer.transform);
    //    navInfo = tmpagent.GetComponent<ReturnNavmeshInfo>();
    //    endJumpPosition = navInfo.ReturnClosestPointBackToAgent(tmpagent.transform.position);
    //}









}
