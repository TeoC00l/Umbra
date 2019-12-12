using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GoodEnding_Church1Controller : MonoBehaviour
{

    public GameObject dialogue1, dialogue2, dialogue3;
    public PlayableDirector setStepsForward, aliceOzRuns;

    public string sceneToChangeTo = "";
    bool played = false;
    bool playedSet = false;

    void Start()
    {
        dialogue1.SetActive(true);
    }

    private void Update()
    {
        if(dialogue1.activeSelf == false && !playedSet)
        {
            setStepsForward.Play();
            playedSet = true;

        }
        if(played && dialogue2.activeSelf == false)
        {
            aliceOzRuns.Play();
        }
    }

    public void ActivateDialogue2()
    {
        setStepsForward.Stop();
        dialogue2.SetActive(true);
        played = true;
    }

    public void ChangeScene()
    {
        ObjectHandeler.DeathScreen.GetComponent<DeathscreenTimer>().FadeAndChangeScene(sceneToChangeTo);
    }
}
