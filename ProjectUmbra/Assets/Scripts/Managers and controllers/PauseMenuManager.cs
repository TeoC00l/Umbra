using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private Canvas pauseMenu;
    [SerializeField] private GameObject mainButtons;
    [SerializeField] private GameObject validateExitButtons;
    [SerializeField] private GameObject controlScheme;

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

    public void ValidateExit()
    {
        
        if (mainButtons.activeSelf)
        {
            mainButtons.SetActive(false);
        }
        else if (!mainButtons.activeSelf)
        {
            mainButtons.SetActive(true);
        }
        if (!validateExitButtons.activeSelf)
        {
            validateExitButtons.SetActive(true);
        }
        else if (validateExitButtons.activeSelf)
        {
            validateExitButtons.SetActive(false);
        }
    }

    public void ShowControls()
    {
        if (mainButtons.activeSelf)
        {
            mainButtons.SetActive(false);
        }
        else if (!mainButtons.activeSelf)
        {
            mainButtons.SetActive(true);
        }
        
        if (!controlScheme.activeSelf)
        {
            controlScheme.SetActive(true);
        }
        else if (controlScheme.activeSelf)
        {
            controlScheme.SetActive(false);
        }
    }

    public void Exit()
    {
        Time.timeScale = original;
        SceneManager.LoadScene(0);
    }
}
