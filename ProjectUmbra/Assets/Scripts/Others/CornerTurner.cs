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
    [SerializeField] private bool rightTurn;


    private void Start()
    {
        pm = player.GetComponent<PlayerMovement>();

    }

    private void Update()
    {
    }


    private void TurnRotation(bool hasTurned)
    {
        if (rightTurn)
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
        //if (hasTurned)
        //{
        //    other.attachedRigidbody.velocity = new Vector3(0, other.attachedRigidbody.velocity.y, other.attachedRigidbody.velocity.z);

        //}
        //else
        //{
        //    other.attachedRigidbody.velocity = new Vector3(other.attachedRigidbody.velocity.x, other.attachedRigidbody.velocity.y, 0);

        //}
        other.attachedRigidbody.velocity = Vector3.zero;

        other.gameObject.transform.position = new Vector3(transform.position.x, other.transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pm.cornerTurner = this.gameObject;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (tpd == false && Vector3.Distance(other.transform.position, new Vector3(transform.position.x, other.transform.position.y, transform.position.z)) < 0.5f)
            {

                TranslatePlayerToSelf(other);
                TurnRotation(hasTurned);

                other.gameObject.transform.Rotate(0, turnRotation/* insert variable*/, 0, Space.Self);


                gameObject.SetActive(false);

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
            }

            if (Vector3.Distance(other.transform.position, transform.position) > 0.5f)
            {
                tpd = false;
            }

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
