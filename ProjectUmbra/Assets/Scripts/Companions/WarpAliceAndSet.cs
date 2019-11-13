using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class WarpAliceAndSet : MonoBehaviour
{
    private GameObject alice;
    private GameObject set;
    [SerializeField] private Transform PointToWarpTo;

    private void Start()
    {
        alice = GameObject.FindGameObjectWithTag("Alice");
        set = GameObject.FindGameObjectWithTag("Set");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            alice.GetComponent<NavMeshAgent>().Warp(PointToWarpTo.position);
            set.GetComponent<NavMeshAgent>().Warp(PointToWarpTo.position);
        }

    }
}
