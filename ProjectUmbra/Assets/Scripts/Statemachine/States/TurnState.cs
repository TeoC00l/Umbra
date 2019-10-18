using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/TurnState")]
public class TurnState : BaseState
{
    [SerializeField] private float movementSpeed = 0f;
    private bool rotated = false;
    string lastTurned = "none";
    [SerializeField] private GameObject cornerTurnerObject;
    private CornerTurner cornerTurner;
    private Vector3 direction;

    public override void Enter()
    {
        direction = MovementHandler.getInput();
        MovementHandler.setSpeed(movementSpeed);
        cornerTurner= cornerTurnerObject.GetComponent<CornerTurner>();
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

        MovementHandler.AutoMove(direction);

        if (rotated == true && cornerTurner.getTurningStatus() == false)
        {
            Debug.Log("Exited");
            rotated = false;
            MovementHandler.setLocked();
            owner.Transition<WalkState>();
        }
    }

    void OnTriggerStay(Collider other)
    {
        
    }

    public override void Exit()
    {
        base.Exit();
    }
}