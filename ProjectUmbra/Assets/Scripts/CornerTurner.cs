using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerTurner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private bool isTurning = false;
    private PlayerMovement pm;

    private void Start() {
        pm = player.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            pm.setLocked();
            isTurning = true;
            Debug.Log("isTurning = true");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTurning = false;
            Debug.Log("isTurning = false");
        }
    }

    public bool getTurningStatus()
    {
        return isTurning;
    }
}
