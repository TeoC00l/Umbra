using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionJumpTrigger : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Set") )
        {
            other.GetComponent<CompanionHandler>().SetCanJump = true;

        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Set"))
        {
            other.GetComponent<CompanionHandler>().SetCanJump = false;
            other.GetComponent<CompanionHandler>().isCalced = false;

        }
    }

}
