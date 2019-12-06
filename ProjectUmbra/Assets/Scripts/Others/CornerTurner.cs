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

    [SerializeField]public int cornerTurnMode;
    //Cornerturn mode is a value 0-3
    //0 is forward, 1 is right, 2 is back, and 3 is left
    //this value serves to identify the rotation of the players character

    private void Start()
    {
    }

    private void Update()
    {
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
            //Debug.Log("Entered cornerturnmode " + cornerTurnMode);
            pm = other.gameObject.GetComponent<PlayerMovement>();
            pm.cornerTurner = gameObject;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (tpd == false && Vector3.Distance(other.transform.position, new Vector3(transform.position.x, other.transform.position.y, transform.position.z)) < 0.5f)
            {
                pm.cornerTurnerMode = this.cornerTurnMode;

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

    public bool GetTurnDirection()
    {
        return hasTurned;
    }
}
