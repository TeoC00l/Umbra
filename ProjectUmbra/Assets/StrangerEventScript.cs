using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrangerEventScript : MonoBehaviour
{
    [SerializeField] private GameObject stranger;

    // Start is called before the first frame update
    void Start()
    {
        stranger.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            stranger.SetActive(true);
        }
    }
}

