using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeListener : MonoBehaviour
{
    [SerializeField] private GameObject trigger;
    [SerializeField] private int sceneToLoad;

    void Start()
    {
        
    }

    void Update()
    {
        if (!trigger.activeSelf)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
