﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InActivateAliceAndSet : MonoBehaviour
{

    private GameObject alice;
    private GameObject set;
    [SerializeField] private GameObject followerIcons;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            try {
                //ObjectHandeler.Alice.SetActive(false);
                //ObjectHandeler.Set.SetActive(false);

                //ObjectHandeler.SetActiveStatusForCompanions(false);
                //followerIcons.SetActive(false);
                StartCoroutine(PlayParticlesAndSetInactive());
            }
            catch (System.NullReferenceException)
            {
                Debug.Log("deActivate set and alice FAIL");
            }
        }
    }

    private IEnumerator PlayParticlesAndSetInactive()
    {
        ObjectHandeler.Set.GetComponentInChildren<ParticleSystem>().Play();
        ObjectHandeler.Alice.GetComponentInChildren<ParticleSystem>().Play();
        yield return new WaitForSeconds(0.35f);
        ObjectHandeler.SetActiveStatusForCompanions(false);
        followerIcons.SetActive(false);
    }
}
