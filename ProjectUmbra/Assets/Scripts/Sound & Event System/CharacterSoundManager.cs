using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundManager : MonoBehaviour
{
    private AudioSource source;
    [SerializeField] private AudioClip footSteps;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayFootSteps()
    {
        source.PlayOneShot(footSteps);
    }
}
