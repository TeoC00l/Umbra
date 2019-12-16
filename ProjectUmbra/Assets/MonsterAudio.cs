using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAudio : MonoBehaviour
{

    private AudioSource source;
    public AudioClip clip;

    void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine(PlaySound());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator PlaySound()
    {
        source.PlayOneShot(clip);
        yield return new WaitForSeconds(Random.Range(0, 3));
        StartCoroutine(PlaySound());
    }
}
