using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceBoardAnimator : MonoBehaviour
{
    [SerializeField] public Animator animator;
    [SerializeField] private bool isPointA;
    private int collidersInTrigger = 0;

    private void Start()
    {
        animator = GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(isPointA);
        collidersInTrigger++;
        //if(collidersInTrigger >= 2)
        //{
        //    animator.SetBool("IsWeighed", isPointA);
        //}
        animator.SetBool("IsWeighed", isPointA);
    }

    private void OnTriggerExit(Collider other)
    {
        collidersInTrigger--;
    }
}
