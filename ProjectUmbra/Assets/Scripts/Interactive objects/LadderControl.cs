using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class LadderControl : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private BoxCollider boxCollider;
    [Tooltip("Check this if the player should snap to ladder in X axis, leave unchecked if player should snap in Z axis")]
    [SerializeField] private bool useXAxis;


    public bool isSnaped = false;


    public void Start()
    {

        boxCollider = GetComponent<BoxCollider>();

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovement = other.GetComponent<PlayerMovement>();

            playerMovement.LadderCollider = GetComponent<BoxCollider>();
            isSnaped = false;
        }

    }
    public void OnTriggerStay(Collider other)
    {
        if (isSnaped == false)
        {
            if ((other.CompareTag("Player") && ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))) && !playerMovement.getLadderStatus())
            {
                playerMovement.setLadderStatus(true);
                Vector3 playerPosition;
                if (useXAxis)
                {
                    playerPosition = new Vector3(boxCollider.transform.position.x, other.transform.position.y, other.transform.position.z);
                }
                else
                {
                    playerPosition = new Vector3(other.transform.position.x, other.transform.position.y, boxCollider.transform.position.z);
                }
                other.transform.position = playerPosition;
                isSnaped = true;
            }
        }
        

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && playerMovement.getLadderStatus())
        {

            isSnaped = false;
            playerMovement.setLadderStatus(false);
        }
    }








    //DeathComponent.cachedPosition = other.transform.position;



    //if (other.CompareTag("Set"))
    //{
    //    other.transform.SetParent(transform);
    //    other.GetComponent<NavMeshAgent>().enabled = false;
    //    if(isSnaped == false)
    //    {
    //        other.transform.position = lowerTrans.position;
    //        Debug.Log("snap");
    //        isSnaped = true;
    //        if (isSnaped)
    //        {
    //            other.attachedRigidbody.MovePosition(higherTrans.position);
    //            Debug.Log("higher");
    //        }

    //    }


    //}

}



