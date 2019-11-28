using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{

    [SerializeField] private int newGameSceneNumber, demoSceneNumber;
    [SerializeField] private GameObject mainButtons;
    [SerializeField] private GameObject validateQuit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Demo()
    {
        SceneManager.LoadScene(demoSceneNumber);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameSceneNumber);
    }


    public void Options()
    {

    }

    public void LoadSave()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        SceneManager.LoadScene(data.lastLoadedSceneIndex);
        Player player = FindObjectOfType<Player>();

        Vector3 savedPosition = new Vector3();
        savedPosition.x = data.latestPassedCheckpoint[0];
        savedPosition.y = data.latestPassedCheckpoint[1];
        savedPosition.z = data.latestPassedCheckpoint[2];

        player.transform.position = savedPosition;
    }

    public void ApplyAndReturn()
    {

    }

    public void ResetToDefault()
    {

    }

    public void ValidateQuit()
    {
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
        Debug.Log("Hejdå!");
        Application.Quit();
    }
}
