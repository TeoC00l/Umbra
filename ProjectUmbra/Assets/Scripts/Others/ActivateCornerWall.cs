using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCornerWall : MonoBehaviour
{
    private BoxCollider collider;

    void Start()
    {
        collider = GetComponent<BoxCollider>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collider.isTrigger = false;
        }
    }
}
