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
        animator = this.GetComponent<Animator>();
        deathScreen.gameObject.SetActive(true);
        deathScreen.canvasRenderer.SetAlpha(0.0f);
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
        animator.SetTrigger("FadeIn");
    }
    public void FadeOut()
    {
        animator.SetTrigger("FadeOut"); ;
    }
}
