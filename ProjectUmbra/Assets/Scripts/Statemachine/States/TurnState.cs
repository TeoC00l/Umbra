using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/TurnState")]
public class TurnState : BaseState
{
    [SerializeField] private float movementSpeed = 0f;
    private bool rotated = false;
    string lastTurned = "none";

    public override void Enter()
    {
        MovementHandler.setSpeed(movementSpeed);
    }

    public override void HandleUpdate()
    {
        if (!rotated)
        {
            if (lastTurned.Equals("none") || lastTurned.Equals("right"))
            {
                owner.transform.Rotate(0, -90, 0, Space.Self);
                lastTurned = "left";
            }
            else if (!rotated && lastTurned.Equals("left"))
            {
                owner.transform.Rotate(0, 90, 0, Space.Self);
                lastTurned = "right";
            }
            rotated = true;
        }
        if (rotated)
        {
            rotated = false;
            MovementHandler.setLocked();
            owner.Transition<WalkState>();
        }
    }
}