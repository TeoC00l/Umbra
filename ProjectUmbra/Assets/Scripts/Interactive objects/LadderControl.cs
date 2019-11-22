using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class LadderControl : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private BoxCollider boxCollider;
    [Tooltip("Check this if the player should snap to ladder in X axis, leave unchecked if player should snap in Z axis")]
    [SerializeField] private bool useX;


    private bool isSnaped = false;


    public void Start()
    {

        boxCollider = GetComponent<BoxCollider>();
  
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) { 
            playerMovement = other.GetComponent<PlayerMovement>();

            playerMovement.LadderCollider = GetComponent<BoxCollider>();
        }

    }
    public void OnTriggerStay(Collider other)
    {
        if ((other.CompareTag("Player") && ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)))) && !playerMovement.getLadderStatus())
        {
            //Debug.Log(boxCollider.size.y);
            playerMovement.setLadderStatus(true);
            Vector3 pos;
            if (useX) { 
                pos = new Vector3(boxCollider.transform.position.x, other.transform.position.y, other.transform.position.z);
            }
            else
            {
                pos = new Vector3(other.transform.position.x, other.transform.position.y, boxCollider.transform.position.z);
            }
            //pos = pos.normalized;
            other.transform.position = pos;
            //other.transform.Translate(pos);
        }
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

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && playerMovement.getLadderStatus())
        {

            //DeathComponent.cachedPosition = other.transform.position;

            playerMovement.setLadderStatus(false);
        }
    }

}
