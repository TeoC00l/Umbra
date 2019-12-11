using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Church3_CutsceneController : MonoBehaviour
{
    public DialogueManager isSetDone;
    public GameObject player;
    public ParticleSystem particles;

    private bool running = false;

    private void Start()
    {

    }
    private void Update()
    {
        if (isSetDone.Done && !running)
        {
            StartCoroutine(DisappearOz());
            running = true;
        }
    }

    private IEnumerator DisappearOz()
    {
        particles.transform.position = player.transform.position;
        particles.Play();
        yield return new WaitForSeconds(2);
        player.SetActive(false);
        AudioManager.instance.Play("Alice&Set_Appear");
        ObjectHandeler.DeathScreen.GetComponent<DeathscreenTimer>().FadeAndChangeScene("Cutscene_BadEnding3");
    }
}
