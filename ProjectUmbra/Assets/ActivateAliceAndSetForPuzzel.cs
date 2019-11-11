using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ActivateAliceAndSetForPuzzel : MonoBehaviour
{
    private GameObject alice;
    private GameObject set;

    private void Awake()
    {
        alice = ObjectHandeler.Alice;
        set = ObjectHandeler.Set;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            set.SetActive(true);
            alice.SetActive(true);

            set.GetComponent<NavMeshAgent>().Warp(transform.position);
            alice.GetComponent<NavMeshAgent>().Warp(transform.position);


            gameObject.SetActive(false);

        }
    }
}
