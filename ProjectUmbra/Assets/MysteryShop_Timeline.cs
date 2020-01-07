using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Aura2API;

public class MysteryShop_Timeline : MonoBehaviour
{

    public ParticleSystem shopkeeperParticles, playerParticles;
    public Light[] lights;
    public AuraVolume mist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerSKParticles()
    {
        shopkeeperParticles.Play();
    }

    public void TriggerPlayerParticles()
    {
        playerParticles.Play();
    }

    public void ChangeLights()
    {
        foreach(Light l in lights)
        {
            l.color = Color.magenta;
        }
        mist.lightInjection.color = Color.magenta;
    }
}
