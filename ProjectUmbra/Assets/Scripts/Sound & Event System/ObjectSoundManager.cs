using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSoundManager : MonoBehaviour
{
    private AudioSource source;
    [SerializeField] private AudioClip clip1, clip2;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayAudioClip1()
    {
        source.PlayOneShot(clip1);
    }

    public void PlayAudioClip2()
    {
        source.PlayOneShot(clip2);
    }

    public void PlayLooping()
    {
        source.Play();
    }
}
