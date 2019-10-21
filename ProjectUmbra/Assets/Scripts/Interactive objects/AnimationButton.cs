using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class AnimationButton : MonoBehaviour
{
    private Animator anim;
    private bool isPressed = false;
    [SerializeField] GameObject animGO;

    // Start is called before the first frame update
    void Start()
    {
        anim = animGO.GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (!isPressed)
                {

                    anim.SetBool("Active", true);
                    //anim.Play("Door_Closed", -1, anim.animation);

                    isPressed = true;
                    return;
                }
                
                if(isPressed)
                {
                    anim.SetBool("Active", false);

                    //anim.Play("Door_Open", -1, anim.);

                    isPressed = false;
                    return;
                }
                
            }
        }
    }


    private float CheckPlaybackTime()
    {
        float time;

        if (anim.playbackTime < 1)
        {
            time = 1 - anim.playbackTime;
            return time;
        }
        else
        {
            time = 0;
        }
        return 0f;
    }
}
