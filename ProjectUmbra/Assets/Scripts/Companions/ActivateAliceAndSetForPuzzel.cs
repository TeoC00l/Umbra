using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ActivateAliceAndSetForPuzzel : MonoBehaviour
{
    private GameObject alice;
    private GameObject set;
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private GameObject followerIcons;
    [SerializeField] private Transform aliceSpawn;
    [SerializeField] private Transform setSpawn;


    private void Awake()
    {
       
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //ObjectHandeler.Set.SetActive(true);
            //ObjectHandeler.Alice.SetActive(true);
            ObjectHandeler.SetActiveStatusForCompanions(true);
            AudioManager.instance.Play("Alice&Set_Appear");

            ObjectHandeler.Set.GetComponent<NavMeshAgent>().Warp(setSpawn.position);
            ObjectHandeler.Alice.GetComponent<NavMeshAgent>().Warp(aliceSpawn.position);

            try
            {
                particles.Play();
                followerIcons.SetActive(true);
            }
            catch (UnityEngine.UnassignedReferenceException)
            {

            }

            gameObject.SetActive(false);

        }
    }
}
