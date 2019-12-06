using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnHit : MonoBehaviour
{


    public Transform SpawnPosition;
    //public int Index;
    //[SerializeField] private FallingObjectsHandeler fallingObjectsHandeler;
    private bool isKilling;
    [SerializeField] float randomRangeMax = 1.5f;
    private Rigidbody goRigidbody;
    private float coolDown;
    private bool isFalling;



    private void Start()
    {
        
        isKilling = true;
        isFalling = false;
        goRigidbody = GetComponent<Rigidbody>();
        goRigidbody.isKinematic = true;
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isKilling = false;
            //isFalling = false;
            RespawnFallingObjects();

        }

        if (collision.collider.CompareTag("Player"))
        {
            if(isKilling == true)
            {
                Debug.Log("Hit by falling object -> DieOnHit.cs");

                RespawnFallingObjects();
                collision.collider.GetComponent<DeathComponent>().RespawnPlayer();
            }


        }

    }

    private void Update()
    {
        DoFalling();
    }

    public void RespawnFallingObjects()
    {

        transform.position = SpawnPosition.position;
        goRigidbody.isKinematic = true;
        coolDown = Random.Range(0, randomRangeMax);


    }



    private void DoFalling()
    {
        if(isFalling == true)
        {
            if (coolDown < 0)
            {
                goRigidbody.isKinematic = false;

            }
            else
            {
                coolDown -= Time.deltaTime;
            }
        }

    }


    public void SetObjectToFalling()
    {
        isKilling = true;
        isFalling = true;
        coolDown = Random.Range(0, randomRangeMax);

    }


    public void SetObjectToNotFalling()
    {
        isKilling = false;
        isFalling = false;

    }

}
