using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathscreenTimer : MonoBehaviour
{
    [SerializeField] private Image deathScreen;

    private bool fading;

    private void Start()
    {
        deathScreen.gameObject.SetActive(true);
        deathScreen.canvasRenderer.SetAlpha(0.0f);
    }

    public void startFade()
    {
        
        StartCoroutine(Fade());
    }

    public IEnumerator Fade()
    {
        deathScreen.CrossFadeAlpha(1, 0.5f, false);
        yield return new WaitForSeconds(2);
        deathScreen.CrossFadeAlpha(0, 2.0f, false);
    }
}
