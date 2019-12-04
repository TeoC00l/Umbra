using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectsHandeler : MonoBehaviour
{

    [SerializeField] private GameObject[] fallingObjectsGOs;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject fallingGO in fallingObjectsGOs)
            {
                fallingGO.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }


    public void RespawnFallingObjects()
    {
        Debug.Log("respawnFallingObjects");
        foreach (GameObject fallingGO in fallingObjectsGOs)
        {
           fallingGO.transform.position = fallingGO.GetComponent<DieOnHit>().StartPosition;
            fallingGO.GetComponent<Rigidbody>().isKinematic = true;
            
        }
    }

}
