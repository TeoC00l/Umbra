using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuManager : MonoBehaviour
{

    [SerializeField] private int newGameSceneNumber, demoSceneNumber;
    [SerializeField] private GameObject mainButtons;
    [SerializeField] private GameObject validateQuit, optionButtons;
    [SerializeField] private Toggle fontToggle;

    #region DefaultValues

    private bool defaultFont = false;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonMouseOver()
    {
        AudioManager.instance.Play("ButtonMouseOver");
    }

    public void Demo()
    {
        AudioManager.instance.Play("ButtonClicked");
        SceneManager.LoadScene(demoSceneNumber);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameSceneNumber);
    }


    public void Options()
    {
        AudioManager.instance.Play("ButtonClicked");
        optionButtons.SetActive(true);
        mainButtons.SetActive(false);
    }

    public void LoadSave()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        SceneManager.LoadScene(data.lastLoadedSceneIndex);
        KarmaManager.Karma = data.currentKarma;
        //Player player = FindObjectOfType<Player>();

        //Vector3 savedPosition = new Vector3();
        //savedPosition.x = data.latestPassedCheckpoint[0];
        //savedPosition.y = data.latestPassedCheckpoint[1];
        //savedPosition.z = data.latestPassedCheckpoint[2];

        //player.transform.position = savedPosition;
    }

    public void ApplyAndReturn()
    {
        AudioManager.instance.Play("ButtonClicked");
        optionButtons.SetActive(false);
        mainButtons.SetActive(true);
    }

    public void ResetToDefault()
    {
        AudioManager.instance.Play("ButtonClicked");
        optionButtons.SetActive(false);
        mainButtons.SetActive(true);
        fontToggle.isOn = false;
    }

    public void ValidateQuit()
    {
        AudioManager.instance.Play("ButtonClicked");
        if (mainButtons.activeSelf) {
            mainButtons.SetActive(false);
        }
        else if (!mainButtons.activeSelf)
        {
            mainButtons.SetActive(true);
        }
        if (!validateQuit.activeSelf) { 
            validateQuit.SetActive(true);
        }
        else if (validateQuit.activeSelf)
        {
            validateQuit.SetActive(false);
        }

    }

    public void Quit()
    {
        AudioManager.instance.Play("ButtonClicked");
        Debug.Log("Hejdå!");
        Application.Quit();
    }
}
