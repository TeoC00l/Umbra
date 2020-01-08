using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuManager : MonoBehaviour
{

    [SerializeField] private int newGameSceneNumber, demoSceneNumber;
    [SerializeField] private GameObject mainButtons, continueButton;
    [SerializeField] private GameObject validateQuit, optionButtons;
    [SerializeField] private Toggle fontToggle;
    [SerializeField] private Slider speedSlider;
    [SerializeField] private GameObject speedValue;

    #region DefaultValues

    private bool defaultFont = false;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if(SaveSystem.LoadPlayer() != null)
        {
            Button b = continueButton.GetComponent<Button>();
            ColorBlock cb = b.colors;
            cb.normalColor = Color.white;
            b.colors = cb;
        }

        PlayerPrefs.SetInt("PlayerSpeed", 10);
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
        KarmaManager.SetKarma(0);
        try
        {
            PlayerData data = SaveSystem.LoadPlayer();
            data.lastLoadedSceneIndex = 0;
            data.currentKarma = 0;
        }
        catch (System.NullReferenceException)
        {
            Debug.Log("No save file");
        }
        SceneManager.LoadScene(newGameSceneNumber);
    }


    public void Options()
    {
        AudioManager.instance.Play("ButtonClicked");
        optionButtons.SetActive(true);
        mainButtons.SetActive(false);
    }

    public void SetOpenDyslexic()
    {
        if (fontToggle.isOn)
        {
            OptionSettingsStorage.OpenDyslexic = true;
            PlayerPrefs.SetInt("UseOpenDyslexic", 1);
        } else
        {
            OptionSettingsStorage.OpenDyslexic = false;
            PlayerPrefs.SetInt("UseOpenDyslexic", 0);
        }
    }

    public void SetPlayerSpeed()
    {
        PlayerPrefs.SetInt("PlayerSpeed", (int)speedSlider.value);
        speedValue.GetComponent<Text>().text = speedSlider.value.ToString();
    }

    public void LoadSave()
    {
        try
        {
            PlayerData data = SaveSystem.LoadPlayer();
            SceneManager.LoadScene(data.lastLoadedSceneIndex);
            KarmaManager.SetKarma(data.currentKarma);
        }
        catch (System.NullReferenceException)
        {

        }
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
        speedSlider.value = 10;
        SetPlayerSpeed();
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
