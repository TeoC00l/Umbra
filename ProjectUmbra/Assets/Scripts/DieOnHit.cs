using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnHit : MonoBehaviour
{


    public Vector3 StartPosition;
    [SerializeField] private FallingObjectsHandeler fallingObjectsHandeler;
    private bool isKilling;

    private void Start()
    {
        StartPosition = transform.position;
        isKilling = true;

    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isKilling = false;
        }

        if (collision.collider.CompareTag("Player"))
        {
            if(isKilling == true)
            {
                Debug.Log("Hit by falling object -> DieOnHit.cs");
                fallingObjectsHandeler.RespawnFallingObjects();

                //collision.collider.GetComponent<DeathComponent>().RespawnPlayer();
            }


        }

    }
}
