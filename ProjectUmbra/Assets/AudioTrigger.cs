using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{

    public string soundToPlay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.instance.Play(soundToPlay);
            gameObject.SetActive(false);
        }
    }
}
