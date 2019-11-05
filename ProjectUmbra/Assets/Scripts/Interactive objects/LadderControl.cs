using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderControl : MonoBehaviour
{
    private PlayerMovement pm;
    private BoxCollider boxCollider;

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
        if (other.CompareTag("Player") && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)) && !pm.getLadderStatus())
        {
            pm.setLadderStatus(true);
            Vector3 pos = new Vector3(boxCollider.transform.position.x, other.transform.position.y, other.transform.position.z);
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
