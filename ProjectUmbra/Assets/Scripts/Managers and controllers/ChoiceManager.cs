using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceManager : MonoBehaviour
{
    [SerializeField] private int karmaChoice1, karmaChoice2;
    [SerializeField] private int SetChoice_SceneToLoad, AliceChoice_SceneToLoad;

    public void Choice1()
    {
        AddKarma(karmaChoice1);
        SceneManager.LoadScene(SetChoice_SceneToLoad);
    }

    public void Choice2()
    {
        AddKarma(karmaChoice2);
        SceneManager.LoadScene(AliceChoice_SceneToLoad);
    }

    public void AddKarma(int karma)
    {
        KarmaManager.Karma = karma;
        
    }
}
