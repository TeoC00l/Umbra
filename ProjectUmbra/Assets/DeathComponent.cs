using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathComponent : MonoBehaviour
{
    [SerializeField] private int fallDistanceToDie;


    private PlayerMovement pm;
    private bool cachedGroundedPos;
    private Vector3 cachedPosition;
    private bool hasCalculatedAirDistance;
    private float fallDistance;
    
    
    // Start is called before the first frame update
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
    }


    private void Update()
    {
        if (pm.IsGrounded() == false)
        {
            hasCalculatedAirDistance = false;
            if (cachedGroundedPos == false)
            {
                cachedPosition = gameObject.transform.position;
                cachedGroundedPos = true;
            }
        }
        else
        {
            if (hasCalculatedAirDistance == false)
            {

                fallDistance = cachedPosition.y - gameObject.transform.position.y;
                if (fallDistance > fallDistanceToDie)
                {
                    Debug.Log(fallDistance + " fall distance");

                    gameObject.SetActive(false);
                }
                fallDistance = 0;
                cachedGroundedPos = false;
                hasCalculatedAirDistance = true;
            }
        }
    }


}
