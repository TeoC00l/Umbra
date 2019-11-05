using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeTrigger : MonoBehaviour
{
    [SerializeField] private int sceneToChangeTo = 0;
    [SerializeField] private Image fadeScreen;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeOut());
            //SceneManager.LoadScene(sceneToChangeTo);
        }
    }

    //void OnEnable()
    //{
    //    SceneManager.sceneLoaded += OnSceneLoaded;
    //}

    //void OnDisable()
    //{
    //    SceneManager.sceneLoaded -= OnSceneLoaded;
    //}

    //private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    StartCoroutine(FadeIn());
    //}

    public IEnumerator FadeOut()
    {
        fadeScreen.canvasRenderer.SetAlpha(0.0f);
        fadeScreen.CrossFadeAlpha(1, 0.5f, false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneToChangeTo);
    }

}
