using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTrigger : MonoBehaviour
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
                    anim.SetBool("WallLowered", true);
                    
                    isPressed = true;
                    return;
                }

                if (isPressed)
                {
                    anim.SetBool("WallLowered", false);
                    isPressed = false;
                    return;
                }

            }
        }
    }
}
