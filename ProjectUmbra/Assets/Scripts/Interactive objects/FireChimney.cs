using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireChimney : MonoBehaviour
{
    [SerializeField] private ParticleSystem fire;
    private BoxCollider fireCollider;
    [SerializeField] private GameObject player;

    private AudioSource source;
    private DeathComponent dc;
    private bool fireActive = false;
    private bool playing = true;

    private void Start()
    {
        dc = player.GetComponent<DeathComponent>();
        source = GetComponent<AudioSource>();
        StartCoroutine(FireTimer());
        fireCollider = GetComponent<BoxCollider>();
        
    }

    

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && fireActive)
        {
            dc.RespawnPlayer();
        }
    }

    private IEnumerator FireTimer()
    {
        while (playing) { 
            fireActive = true;
            fire.Play();
            source.PlayOneShot(source.clip);
            yield return new WaitForSeconds(3);
            fire.Stop();
            fireActive = false;
            yield return new WaitForSeconds(3);
        }
    }
}
