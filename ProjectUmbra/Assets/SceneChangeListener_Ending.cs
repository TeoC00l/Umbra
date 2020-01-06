using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneChangeListener_Ending : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string sceneToLoad = "";

    // Update is called once per frame
    void Update()
    {
        if (!videoPlayer.isPlaying)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
