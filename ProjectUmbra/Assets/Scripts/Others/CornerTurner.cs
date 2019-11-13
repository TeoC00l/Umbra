using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerTurner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private bool isTurning = false;
    private PlayerMovement pm;

    private bool tpd;
    private int turnRotation;

    private bool hasTurned;
    [SerializeField] private bool leftTurn;
    private bool horizontalPathUpdateIsX;


    private void Awake()
    {
        pm = player.GetComponent<PlayerMovement>();

    }



    private void TurnRotation(bool hasTurned)
    {
        if (leftTurn)
        {
            if (hasTurned == false)
            {
                turnRotation = -90;
            }
            else
            {
                turnRotation = 90;
            }
        }
        else
        {
            if (hasTurned == false)
            {
                turnRotation = 90;
            }
            else
            {
                turnRotation = -90;
            }
        }
        
    }


    private void TranslatePlayerToSelf(Collider other)
    {

        other.attachedRigidbody.velocity = Vector3.zero;

        other.gameObject.transform.position = new Vector3(transform.position.x, other.transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pm.cornerTurner = gameObject;

            pm.GetNextCorner();

            if (pm.isUpdatingXPosition)
            {
                pm.isUpdatingXPosition = false;
            }
            else
            {
                pm.isUpdatingXPosition = true;
            }
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (tpd == false && Vector3.Distance(other.transform.position, new Vector3(transform.position.x, other.transform.position.y, transform.position.z)) < 0.5f)
            {
                
                if(tpd == false)
                {
                    other.GetComponent<PlayerMovement>().isUpdatingXPosition = !other.GetComponent<PlayerMovement>().isUpdatingXPosition;
                }
                TranslatePlayerToSelf(other);
                TurnRotation(hasTurned);

                other.gameObject.transform.Rotate(0, turnRotation/* insert variable*/, 0, Space.Self);




                gameObject.GetComponent<BoxCollider>().enabled = false;

                //gameObject.SetActive(false);

                //GetComponent<BoxCollider>().isTrigger = false;
                hasTurned = false;
                tpd = true;
                //if (hasTurned)
                //{
                //    hasTurned = false;
                //}
                //else
                //{
                //    hasTurned = true;
                //}
                //Debug.Log(hasTurned);




                //if (other.GetComponent<HorizontalPathUpdate>().isUpdatingXPosition)
                //{
                //    other.GetComponent<HorizontalPathUpdate>().isUpdatingXPosition = false;
                //}
                //else
                //{
                //    other.GetComponent<HorizontalPathUpdate>().isUpdatingXPosition = true;
                //}

            }

            //if (Vector3.Distance(other.transform.position, transform.position) > 0.5f)
            //{
            //    tpd = false;

            //}

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTurning = false;
            tpd = false;

        }
    }

    public bool getTurningStatus()
    {
        return isTurning;
    }
}
