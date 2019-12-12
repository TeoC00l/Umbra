using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnSignal : MonoBehaviour
{

    public string SceneToChangeTo;

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneToChangeTo);
    }
}
