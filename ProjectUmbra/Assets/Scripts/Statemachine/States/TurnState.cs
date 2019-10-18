using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/TurnState")]
public class TurnState : BaseState
{
    [SerializeField] private float movementSpeed = 0f;
    private bool rotated = false;
    string lastTurned = "none";
    private CornerTurner cornerTurner;
    private Vector3 direction = Vector3.zero;

    public override void Enter()
    {
        cornerTurner = MovementHandler.cornerTurner;
        direction = MovementHandler.getInput();
        //MovementHandler.setSpeed(movementSpeed);

    }

    public override void HandleUpdate()
    {

        //if (!rotated)
        //{
        //    if (lastTurned.Equals("none") || lastTurned.Equals("right"))
        //    {
        //        owner.transform.Rotate(0, -90, 0, Space.Self);
        //        lastTurned = "left";
        //    }
        //    else if (!rotated && lastTurned.Equals("left"))
        //    {
        //        owner.transform.Rotate(0, 90, 0, Space.Self);
        //        lastTurned = "right";
        //    }
        //    rotated = true;
        //}

        

        if (rotated == true && cornerTurner.getTurningStatus() == false)
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