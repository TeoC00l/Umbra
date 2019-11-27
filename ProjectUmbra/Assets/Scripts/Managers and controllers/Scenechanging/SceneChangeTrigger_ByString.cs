using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeTrigger_ByString : MonoBehaviour
{
    [SerializeField] private string sceneToChangeTo = "";
    [SerializeField] private Image fadeScreen;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeOut());
        }
    }

    public IEnumerator FadeOut()
    {
        fadeScreen.canvasRenderer.SetAlpha(0.0f);
        fadeScreen.CrossFadeAlpha(1, 0.5f, false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneToChangeTo);
    }

}


