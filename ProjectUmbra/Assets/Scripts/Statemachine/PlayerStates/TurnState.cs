using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/TurnState")]
public class TurnState : BaseState
{
    private bool rotated;
    private GameObject cornerTurner;
    private Vector3 direction;

    public override void Enter()
    {

        cornerTurner = MovementHandler.cornerTurner;
        direction = MovementHandler.getInput();
        rotated = false;
        direction = Vector3.zero;
    }

    public override void HandleUpdate()
    {
        if (rotated == true && cornerTurner.GetComponent<CornerTurner>().getTurningStatus() == false)
        {
            Debug.Log("Exited");
            rotated = false;
            MovementHandler.setLocked();
            owner.Transition<WalkState>();
        }
    }

    public override void HandleFixedUpdate()
    {
        MovementHandler.AutoMove(direction);
    }
}