using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChangeTrigger_KarmaDependent : MonoBehaviour
{
    [SerializeField] private string scene1 = "", scene2 = "";
    [SerializeField] private Image fadeScreen;
    [SerializeField] private int karma_1, karma_2;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(KarmaManager.Karma >= karma_1)
            {
                StartCoroutine(FadeOut(scene1));
            } else
            {
                StartCoroutine(FadeOut(scene2));
            }
            
        }
    }

    public IEnumerator FadeOut(string sceneToChangeTo)
    {
        fadeScreen.canvasRenderer.SetAlpha(0.0f);
        fadeScreen.CrossFadeAlpha(1, 0.5f, false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneToChangeTo);
    }
}
