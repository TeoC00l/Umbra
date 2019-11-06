using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderControl : MonoBehaviour
{
    private PlayerMovement pm;
    private BoxCollider boxCollider;
    [Tooltip("Check this if the player should snap to ladder in X axis, leave unchecked if player should snap in Z axis")]
    [SerializeField] private bool useX;

    public void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) { 
            pm = other.GetComponent<PlayerMovement>();
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) && !pm.getLadderStatus())
        {
            pm.setLadderStatus(true);
            Vector3 pos;
            if (useX) { 
                pos = new Vector3(boxCollider.transform.position.x, other.transform.position.y, other.transform.position.z);
            }
            else
            {
                pos = new Vector3(other.transform.position.x, other.transform.position.y, boxCollider.transform.position.z);
            }
            //pos = pos.normalized;
            other.transform.position = pos;
            //other.transform.Translate(pos);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && pm.getLadderStatus())
        {

            DeathComponent.cachedPosition = other.transform.position;

            pm.setLadderStatus(false);
        }
    }
}
