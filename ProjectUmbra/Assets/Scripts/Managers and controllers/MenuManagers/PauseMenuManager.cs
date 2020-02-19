using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject mainButtons;
    [SerializeField] private GameObject firstSelected;
    [SerializeField] private GameObject validateExitButtons, exitButton;
    [SerializeField] private GameObject controlScheme, backButton;

    [SerializeField] private EventSystem es;

    private void OnEnable()
    {
        Cursor.visible = false;
    }

    private void OnDisable()
    {
        Cursor.visible = true;
    }

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
        if (!pauseMenu.activeSelf) { 
            pauseMenu.SetActive(true);
            Cursor.visible = true;

            //es.SetSelectedGameObject(null);
            //es.SetSelectedGameObject(firstSelected);

            //StartCoroutine(HighlightButton(firstSelected));

            //Button btn = es.currentSelectedGameObject.GetComponent<Button>();
            //btn.image.color = new Color(49f, 22f, 41f, 0.56f);

            isPaused = true;
        } else
        {
            Cursor.visible = false;
            mainButtons.SetActive(true);
            validateExitButtons.SetActive(false);
            controlScheme.SetActive(false);
            pauseMenu.SetActive(false);
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
            //StartCoroutine(HighlightButton(firstSelected));
        }
        if (!validateExitButtons.activeSelf)
        {
            validateExitButtons.SetActive(true);
            //StartCoroutine(HighlightButton(exitButton));
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
            //StartCoroutine(HighlightButton(backButton));
        }
        else if (!mainButtons.activeSelf)
        {
            mainButtons.SetActive(true);
            //StartCoroutine(HighlightButton(firstSelected));
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

    public IEnumerator HighlightButton(GameObject toSet)
    {
        es.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        es.SetSelectedGameObject(toSet);



    }
}
