using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundManager : MonoBehaviour
{
    private AudioSource source;
    [SerializeField] private AudioClip footSteps, ladderSound, boxPushingSound;
    [SerializeField] private AudioClip[] stepSounds;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayFootSteps()
    {
        int place = Random.Range(0, 3);
        source.PlayOneShot(stepSounds[place]);
        //source.PlayOneShot(footSteps);


    }

    public void PlayLadderClimb()
    {
        source.PlayOneShot(ladderSound);
    }

    //public void PlayBoxPushingSound()
    //{
    //    source.PlayOneShot(boxPushingSound);
    //}
}
