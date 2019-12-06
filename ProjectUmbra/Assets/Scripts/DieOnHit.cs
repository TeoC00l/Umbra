using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnHit : MonoBehaviour
{


    public Transform SpawnPosition;
    //public int Index;
    //[SerializeField] private FallingObjectsHandeler fallingObjectsHandeler;
    public bool IsKilling;
    [SerializeField] public float randomRangeMax = 1.5f;
    public Rigidbody GoRigidbody;
    public float CoolDown;
    public bool isFalling;
    private FallingObjectsHandeler fallingObjectsHandeler;


    private void Start()
    {
        IsKilling = true;
        isFalling = false;
        GoRigidbody = GetComponent<Rigidbody>();
        GoRigidbody.isKinematic = true;
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground") || collision.collider.CompareTag("Deathzone"))
        {
            IsKilling = false;
            //isFalling = false;
            RespawnFallingObjects();

        }

        

        if (collision.collider.CompareTag("Player"))
        {
            if(IsKilling == true)
            {
                Debug.Log("Hit by falling object -> DieOnHit.cs");
                GetComponentInParent<FallingObjectsHandeler>().RespawnFallingObjects();
                Debug.Log("Respawn");
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
            GoRigidbody.isKinematic = true;
            CoolDown = Random.Range(0, randomRangeMax);




    }


    private void DoFalling()
    {
        if(isFalling == true)
        {
            if (CoolDown < 0)
            {
                GoRigidbody.isKinematic = false;

            }
            else
            {
                CoolDown -= Time.deltaTime;
            }
        }

    }


    public void SetObjectToFalling()
    {
        IsKilling = true;
        isFalling = true;
        CoolDown = Random.Range(0, randomRangeMax);

    }


    public void SetObjectToNotFalling()
    {
        IsKilling = false;
        isFalling = false;

    }

}
