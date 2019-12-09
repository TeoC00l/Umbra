using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitchTrigger : MonoBehaviour
{

    [SerializeField] private string animationBoolKey = "";
    [SerializeField] private GameObject animGO;
    private Animator anim;
    private Animator leverAnimator;

    private Light light;
    private float cooldown = 5;
    private bool isPlaying;
    private void Start()
    {
        anim = animGO.GetComponent<Animator>();
        leverAnimator = GetComponentInChildren<Animator>();
        light = GetComponentInChildren<Light>();

        light.color = Color.yellow;
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (anim.GetCurrentAnimatorStateInfo(0).IsName("FloorAnimationClose"))
                {
                    anim.SetTrigger(animationBoolKey);
                    //GreenLight();
                }
                
                leverAnimator.SetTrigger(animationBoolKey);
                
            }
        }
    }


    private void Update()
    {
        Debug.Log(anim.GetCurrentAnimatorStateInfo(0).IsName("FloorAnimation"));
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("FloorAnimation") == true)
        {
            light.color = Color.green;

        }
        else
        {
            light.color = Color.yellow;

        }
        //if(isPlaying == true)
        //{
        //    if(cooldown <= 0)
        //    {
        //        light.color = Color.yellow;
        //    }
        //    else
        //    {
        //        light.color = Color.green;
        //        cooldown -= Time.deltaTime;
        //    }

        //}
    }


    IEnumerator GreenLight()
    {
        light.color = Color.green;
        Debug.Log("GREEN");
        yield return new WaitForSeconds(5);
        Debug.Log("YEALLOW");
        light.color = Color.yellow;
    }


}
