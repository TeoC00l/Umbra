using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerTurner3 : MonoBehaviour
{
    public Vector3 rotate;
    [SerializeField] private GameObject player;
    private bool isTurning = false;
    private PlayerMovement pm;
    [SerializeField] private Transform rightRotation;
    [SerializeField] private Transform leftRotation;
    private bool tpd;
    private Quaternion turnRotation;

    private bool hasTurnedRight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //other.transform.Rotate(rotate, Space.Self);
            //other.attachedRigidbody.velocity = new Vector3(0, other.attachedRigidbody.velocity.y, 0);
        }
    }



    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (tpd == false && Vector3.Distance(other.transform.position, new Vector3(transform.position.x, other.transform.position.y, transform.position.z)) < 0.3f)
            {

                TranslatePlayerToSelf(other);
                TurnRotation(hasTurnedRight);

                other.gameObject.transform.Rotate(turnRotation.eulerAngles, Space.Self);



                tpd = true;
                if (hasTurnedRight)
                {
                    hasTurnedRight = false;
                }
                else
                {
                    hasTurnedRight = true;
                }
                //Debug.Log(hasTurned);
            }

            if (Vector3.Distance(other.transform.position, transform.position) > 0.3f)
            {
                tpd = false;
            }

        }
    }


    private void TranslatePlayerToSelf(Collider other)
    {
        if (hasTurnedRight)
        {
            other.attachedRigidbody.velocity = new Vector3(0, other.attachedRigidbody.velocity.y, other.attachedRigidbody.velocity.z);

        }
        else
        {
            other.attachedRigidbody.velocity = new Vector3(other.attachedRigidbody.velocity.x, other.attachedRigidbody.velocity.y, 0);

        }

        other.gameObject.transform.position = new Vector3(transform.position.x, other.transform.position.y, transform.position.z);
    }


    private void TurnRotation(bool hasTurnd)
    {
        if (hasTurnedRight == false)
        {
            turnRotation = rightRotation.rotation;
        }
        else
        {
            turnRotation = leftRotation.rotation;
        }
    }
}
