using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectsHandeler : MonoBehaviour
{
    [SerializeField] private GameObject goPrefab;
    private List<GameObject> fallingObjectsGOs;
    [SerializeField] private Transform[] fallingObjectSpawn;
    private int objectCounter;
    private float coolDown;

    private void Awake()
    {
        fallingObjectsGOs = new List<GameObject>();
    }

    private void Start()
    {
        Debug.Log(fallingObjectSpawn.Length);
        for (int i = 0; i <  fallingObjectSpawn.Length; i++)
        {
            GameObject tempGO = Instantiate<GameObject>(goPrefab);
            tempGO.transform.position = fallingObjectSpawn[i].transform.position;
            //Debug.Log(fallingObjectSpawn[i].position);
            //tempGO.GetComponent<DieOnHit>().Index = i;
            tempGO.GetComponent<DieOnHit>().SpawnPosition = fallingObjectSpawn[i].transform;
            fallingObjectsGOs.Add(tempGO);
            //Debug.Log(i);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject fallingObject in fallingObjectsGOs)
            {
                fallingObject.GetComponent<DieOnHit>().SetObjectToFalling();
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach  (GameObject fallingObject in fallingObjectsGOs)
            {
                fallingObject.GetComponent<DieOnHit>().SetObjectToNotFalling();
            }
        }
    }


}
