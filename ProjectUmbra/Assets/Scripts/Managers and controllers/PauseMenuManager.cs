using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private Canvas pauseMenu;
    bool isPaused = false;
    float original;

    public void Start()
    {
        original = Time.timeScale;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu();
        }
    }

    public void PauseMenu()
    {
        if (!pauseMenu.gameObject.activeSelf) { 
            pauseMenu.gameObject.SetActive(true);
            isPaused = true;
        } else
        {
            pauseMenu.gameObject.SetActive(false);
            isPaused = false;
        }
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        if (!isPaused)
        {
            Time.timeScale = original;
        }
    }

    public void Exit()
    {
        //SceneManager.blabla byt scen
        SceneManager.LoadScene(0);
    }
}
