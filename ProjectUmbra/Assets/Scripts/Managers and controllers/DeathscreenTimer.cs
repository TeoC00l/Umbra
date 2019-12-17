using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathscreenTimer : MonoBehaviour
{
    [SerializeField] private Image deathScreen;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        deathScreen.gameObject.SetActive(true);
        //deathScreen.canvasRenderer.SetAlpha(0.0f);
    }

    public void startFade(float time)
    {
        
        StartCoroutine(Fade(time));
    }

    public IEnumerator Fade( float time )
    {
        yield return new WaitForSeconds(time);
        deathScreen.CrossFadeAlpha(1, 0.5f, false);
        yield return new WaitForSeconds(2);
        deathScreen.CrossFadeAlpha(0, 2.0f, false);
    }

    public IEnumerator FadeAndChange(string sceneToChangeTo)
    {
        deathScreen.CrossFadeAlpha(1, 0.5f, false);
        yield return new WaitForSeconds(2);
        deathScreen.CrossFadeAlpha(0, 2.0f, false);
        SceneManager.LoadScene(sceneToChangeTo);
    }

    public void FadeAndChangeScene(string sceneToChangeTo)
    {
        StartCoroutine(FadeAndChange(sceneToChangeTo));
    }

    public void FadeIn()
    {
        Debug.Log("Fade");
        animator.SetTrigger("Fade");
    }
    public void FadeOut()
    {
        animator.SetTrigger("FadeOut"); ;
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        deathScreen.CrossFadeAlpha(0, 2.0f, false);
    }
}
