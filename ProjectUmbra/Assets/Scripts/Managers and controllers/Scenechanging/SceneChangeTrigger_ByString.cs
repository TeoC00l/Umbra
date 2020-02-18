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
            ObjectHandeler.Player.GetComponent<PlayerMovement>().setSpeed(0);

            StartCoroutine(FadeOut());
        }
    }

    public IEnumerator FadeOut()
    {

        fadeScreen.canvasRenderer.SetAlpha(0.0f);
        fadeScreen.CrossFadeAlpha(1, 0.5f, false);
        yield return new WaitForSeconds(2);
        StartCoroutine(LoadYourAsyncScene());

        //SceneManager.LoadScene(sceneToChangeTo);

    }


    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToChangeTo);
        
        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

    }
}


