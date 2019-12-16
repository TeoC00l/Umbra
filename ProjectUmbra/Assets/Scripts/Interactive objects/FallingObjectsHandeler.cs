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

    [SerializeField] private ParticleSystem vfxOnHit;
    private ParticleSystem tempVFX;
    [SerializeField] private Transform vfxParent;


    private void Awake()
    {
        fallingObjectsGOs = new List<GameObject>();
    }

    private void Start()
    {
        //Debug.Log(fallingObjectSpawn.Length);
        for (int i = 0; i < fallingObjectSpawn.Length; i++)
        {
            GameObject tempGO = Instantiate<GameObject>(goPrefab, fallingObjectSpawn[i].transform);
            tempGO.GetComponent<DieOnHit>().fallingObjectsHandeler = this;
            tempGO.transform.position = fallingObjectSpawn[i].transform.position;

            //Debug.Log(fallingObjectSpawn[i].position);
            //tempGO.GetComponent<DieOnHit>().Index = i;
            tempGO.GetComponent<DieOnHit>().SpawnPosition = fallingObjectSpawn[i].transform;
            fallingObjectsGOs.Add(tempGO);
            //Debug.Log(i);
            tempVFX = Instantiate<ParticleSystem>(vfxOnHit, vfxParent);
            tempGO.GetComponent<DieOnHit>().vfxOnHit = tempVFX;


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
            foreach (GameObject fallingObject in fallingObjectsGOs)
            {
                fallingObject.GetComponent<DieOnHit>().SetObjectToNotFalling();
            }
        }
    }

    public void RespawnFallingObjects()
    {
        foreach (GameObject fallingObject in fallingObjectsGOs)
        {
            DieOnHit dieOnHit = fallingObject.GetComponent<DieOnHit>();
            fallingObject.transform.position = dieOnHit.SpawnPosition.position;
            fallingObject.GetComponent<Rigidbody>().isKinematic = true;
            dieOnHit.CoolDown = Random.Range(0, dieOnHit.randomRangeMax);
            Debug.Log("respawn");
        }




    }

}
