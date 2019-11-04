using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CutsceneManager : MonoBehaviour
{

    [SerializeField] private VideoClip[] videos;
    [SerializeField] private GameObject choice;
    private VideoPlayer vp;
    private int videoIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        vp = GetComponentInChildren<VideoPlayer>();
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayNextVideo()
    {
        try
        {
            vp.clip = videos[videoIndex];
            videoIndex++;
        } catch (System.IndexOutOfRangeException)
        {
            gameObject.SetActive(false);
        }
    }
    public void ShutOff()
    {
        //this.gameObject.SetActive(false);
        choice.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
