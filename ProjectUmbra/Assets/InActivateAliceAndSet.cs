using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InActivateAliceAndSet : MonoBehaviour
{

    private GameObject alice;
    private GameObject set;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            alice = GameObject.FindGameObjectWithTag("Alice");
            set = GameObject.FindGameObjectWithTag("Set");

            try { 
                alice.SetActive(false);
                set.SetActive(false);
            }
            catch (System.NullReferenceException)
            {

            }
        }
    }


}
