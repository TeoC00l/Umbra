using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerTurner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private bool isTurning = false;
    private PlayerMovement pm;
    [SerializeField] private Transform rotation1;
    [SerializeField] private Transform rotation2;
    private bool tpd;
    private int turnRotation;
    private void Start() {
        pm = player.GetComponent<PlayerMovement>();
        
    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {


            


            //pm.setVelocity(Vector3.zero);
            //pm.setLocked();
            //isTurning = true;
            //Debug.Log("isTurning = true");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            if (tpd == false && Vector3.Distance(other.transform.position, transform.position) < 0.3f)
            {
                other.gameObject.transform.position = transform.position;
                other.gameObject.transform.Rotate(0, 90/* insert variable*/, 0, Space.Self);
                tpd = true;
            }

            
            // kom på hur man vet vilket håll man ska rotera, lägg det i en variabel som ändrar sig själv
            //efter varje gång man har svängt på den collidern

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTurning = false;
            tpd = false;
            Debug.Log("isTurning = false");
        }
    }

    public bool getTurningStatus()
    {
        return isTurning;
    }
}
