using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPlayerCenterd : MonoBehaviour
{


    private float timeToUpdate = 0.5f;
    [SerializeField] private bool updateZPosition;


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            if (updateZPosition == true)
            {
                other.attachedRigidbody.MovePosition(new Vector3(other.transform.position.x, other.transform.position.y, transform.position.z));

            }
            else
            {
                other.attachedRigidbody.MovePosition (new Vector3(transform.position.x, other.transform.position.y, other.transform.position.z));

            }



            //if (timeToUpdate <= 0)
            //{
            //    timeToUpdate = 0.5f;
            //}
            //else
            //{
            //    timeToUpdate -= Time.fixedDeltaTime;
            //}

        }
    }
}
