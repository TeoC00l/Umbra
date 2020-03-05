using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;

    private string currentlyPlayingMusic = "";

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Sound s = Array.Find(sounds, sound => sound.name == "MainTheme");
        if (s != null)
        {
            PlaySoundTrackForScene();
        }
       
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s != null)
        {
            s.source.Play();
        }
        else
        {
            Debug.Log("Sound clip was not found");
        }
        
    }

    public void PlayOneShot(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s != null)
        {
            s.source.PlayOneShot(s.clip);
        }
        else
        {
            Debug.Log("Sound clip was not found");
        }
    }

    public void Stop (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s != null)
        {
            s.source.Stop();
        }
        else
        {
            Debug.Log("Sound clip was not found");
        }
    }

    public void PlaySoundTrackForScene()
    {
        if (SceneManager.GetActiveScene().name.Equals("MysteryShop"))
        {
            Stop(currentlyPlayingMusic);
            Play("ShopTheme");
            currentlyPlayingMusic = "ShopTheme";
        }
        else if (SceneManager.GetActiveScene().name.ToLower().Equals("whitebox_lvl1") || SceneManager.GetActiveScene().name.ToLower().Equals("whitebox_lvl2") ||
            SceneManager.GetActiveScene().name.ToLower().Equals("whitebox_lvl3"))
        {
            Stop(currentlyPlayingMusic);
            Play("MainTheme");
            currentlyPlayingMusic = "MainTheme";
        } else if (SceneManager.GetActiveScene().name.Equals("Credits"))
            {
                Stop(currentlyPlayingMusic);
                Play("CreditsTheme");
                currentlyPlayingMusic = "CreditsTheme";
        }
        else if (SceneManager.GetActiveScene().name.ToLower().Equals("mainmenu"))
        {
            Stop(currentlyPlayingMusic);
            Play("MainMenuTheme");
            currentlyPlayingMusic = "MainMenuTheme";
        }
        else if (SceneManager.GetActiveScene().name.ToLower().Equals("cutscene_choice2") || SceneManager.GetActiveScene().name.ToLower().Equals("cutscene_choice1")
            || SceneManager.GetActiveScene().name.ToLower().Equals("cutscene_badending1") || SceneManager.GetActiveScene().name.ToLower().Equals("cutscene_goodending1"))
        {
            Stop(currentlyPlayingMusic);
            Play("SuspenseTheme");
            currentlyPlayingMusic = "SuspenseTheme";
        }
        else if (SceneManager.GetActiveScene().name.ToLower().Equals("cutscene_goodendingoutro") || SceneManager.GetActiveScene().name.ToLower().Equals("cutscene_badendingoutro"))
        {
            Stop(currentlyPlayingMusic);
        }
        else if (SceneManager.GetActiveScene().name.Equals("Cutscene_Church"))
        {

            Stop(currentlyPlayingMusic);
            Play("ChurchTheme");
            currentlyPlayingMusic = "ChurchTheme";
        }
        else if (SceneManager.GetActiveScene().name.Equals("Prologue_ChurchToHospital"))
        {
            Stop(currentlyPlayingMusic);
            Play("RegularWorldTheme");
            currentlyPlayingMusic = "RegularWorldTheme";
        }
        else if (SceneManager.GetActiveScene().name.Equals("Cutscene_Hospital"))
        {
            Sound s = Array.Find(sounds, sound => sound.name == "RegularWorldTheme");
            s.source.volume = 0.04f;
            Play("HospitalAmbience");
            currentlyPlayingMusic = "HospitalAmbience";
        }
        else if (SceneManager.GetActiveScene().name.Equals("Prologue_HospitalToRobbery"))
        {
            Stop(currentlyPlayingMusic);

            Sound s = Array.Find(sounds, sound => sound.name == "RegularWorldTheme");
            s.source.volume = 0.04f;

            currentlyPlayingMusic = "RegularWorldTheme";
        }
        else if (SceneManager.GetActiveScene().name.Equals("Prologue_ChurchToHospital2"))
        {
            Stop("CreepyWind");
            Play("RegularWorldTheme");
            PlayOneShot("Gong");
            Sound s = Array.Find(sounds, sound => sound.name == "RegularWorldTheme");
            s.source.volume = 0.04f;

            currentlyPlayingMusic = "RegularWorldTheme";
        }


    }

    private void OnLevelWasLoaded(int level)
    {
        Debug.Log("Playmusic");
        PlaySoundTrackForScene();
    }
}
