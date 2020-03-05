using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrangerEventScript : MonoBehaviour
{
    [SerializeField] private GameObject stranger;
    [SerializeField] private AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        stranger.SetActive(false);    
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            stranger.SetActive(true);
            AudioManager.instance.Stop("RegularWorldTheme");
            AudioManager.instance.Play("CreepyWind");
            AudioManager.instance.PlayOneShot("DramaticSurprise");        
}
    }
}

