using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClimbeLedgeRootAnimation : MonoBehaviour
{




    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                collision.collider.GetComponent<Player>().Transition<ClimbLedgeState>();
            }
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)){
            ObjectHandeler.Player.GetComponent<Player>().Transition<WalkState>();

        }
        
    }


}
