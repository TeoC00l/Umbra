using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoEndScreen : MonoBehaviour
{
    [SerializeField] int sceneToLoad = 0;
    void LoadMainMenu()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadMainMenu();
        }
    }
}
