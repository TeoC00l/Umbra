using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceBoardAnimator : MonoBehaviour
{
    [SerializeField] public Animator animator;
    [SerializeField] private bool isPointA;
    private int collidersInTriggerA = 0;
    private int collidersInTriggerB = 0;


    private void Start()
    {
        animator = GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Grabbable"))
        {
            if (isPointA)
            {
                collidersInTriggerA += 2;
            }
            else
            {
                collidersInTriggerB += 2;
            }
        }
        else if(other.CompareTag("Player") || other.CompareTag("Set") || other.CompareTag("Alice"))
        {
            if (isPointA)
            {
                collidersInTriggerA++;
            }
            else
            {
                collidersInTriggerB++;
            }
            
        }
        if (collidersInTriggerA >= 2)
        {
            animator.SetBool("IsWeighed", true);
        } else if(collidersInTriggerB >= 2)
        {
            animator.SetBool("IsWeighed", false);
        }
        Debug.Log(collidersInTriggerA + " " + collidersInTriggerB);
        //animator.SetBool("IsWeighed", isPointA);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Grabbable"))
        {
            if (isPointA)
            {
                collidersInTriggerA -= 2;
            }
            else
            {
                collidersInTriggerB -= 2;
            }
        }
        else if(other.CompareTag("Player") || other.CompareTag("Set") || other.CompareTag("Alice"))
        {
            if (isPointA)
            {
                collidersInTriggerA--;
            }
            else
            {
                collidersInTriggerB--;
            }

        }
        Debug.Log(collidersInTriggerA + " " + collidersInTriggerB);
    }
}
