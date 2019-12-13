using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GoodEnding_Church3Controller : MonoBehaviour
{

    public ParticleSystem particles1, particles2;
    public GameObject dialogue1, dialogue2;
    public bool set_trigger = false;
    public GameObject shopKeeper;
    public PlayableDirector shopKeeperMoving, cameras;

    bool setDisappeared = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AppearShopKeeper());
    }

    // Update is called once per frame
    void Update()
    {
        if(set_trigger == true && !setDisappeared)
        {
            if(dialogue1.activeSelf == false)
            {
                DisappearSet();
                setDisappeared = true;
                StartCoroutine(ShopkeepWait());
            }

        }
    }

    public IEnumerator AppearShopKeeper()
    {

        particles1.Play();
        shopKeeper.SetActive(true);
        yield return new WaitForSeconds(1);
        ActivateParticles();
        particles1.Stop();
        dialogue1.SetActive(true);
        set_trigger = true;

    }

    public void ActivateParticles()
    {
        particles2.gameObject.SetActive(true);
    }

    public void DisappearSet()
    {
        ObjectHandeler.Set.SetActive(false);
        AudioManager.instance.Play("Alice&Set_Appear");
        particles2.gameObject.SetActive(false);
    }

    public void TriggerDialogue2()
    {
        dialogue2.SetActive(true);
    }

    public void HoldCameraAngle()
    {
        cameras.Pause();
        Debug.Log("Hold");
    }

    private IEnumerator ShopkeepWait()
    {
        yield return new WaitForSeconds(3);
        shopKeeperMoving.Play();
        cameras.Resume();
    }
}
