using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ActivateAliceAndSetForPuzzel : MonoBehaviour
{
    public GameObject alice;
    private GameObject set;

    private void Awake()
    {
        alice = GameObject.FindGameObjectWithTag("Alice");
        set = GameObject.FindGameObjectWithTag("Set");
        //set.SetActive(false);
        //alice.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            set.SetActive(true);
            alice.SetActive(true);

            set.GetComponent<NavMeshAgent>().Warp(transform.position);
            alice.GetComponent<NavMeshAgent>().Warp(transform.position);
        }
    }
}
