using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
public class ClimbeSplineLedge : MonoBehaviour
{

    private Spline ledgeSpline;
   

    private void Awake()
    {
        ledgeSpline = GetComponentInChildren<Spline>();


    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Tween.Spline(ledgeSpline, ObjectHandeler.Player.transform, 0, 1, false, 3, 0, Tween.EaseInOut, Tween.LoopType.None);
            }
        }
    }



}
