using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
public class ClimbeSplineLedge : MonoBehaviour
{

    private Spline ledgeSpline;
    private bool isTweening = false;


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
                //isTweening = true;
                Tween.Spline(ledgeSpline, ObjectHandeler.Player.transform, 0, 1, false, 3, 0, Tween.EaseInOut, Tween.LoopType.None, startClimbeState, EndClimbeState);
                //startClimbeState();
            }
        }
    }

    private void startClimbeState()
    {

        //ObjectHandeler.Player.GetComponent<Player>().isClimbing = true;
        //ObjectHandeler.Player.GetComponent<Player>().Transition<ClimbState>();
    }

    private void EndClimbeState()
    {
        //ObjectHandeler.Player.GetComponent<Player>().isClimbing = false;
        //ObjectHandeler.Player.GetComponent<Player>().Transition<WalkState>();
    }



}
