using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPathUpdate : MonoBehaviour
{
    Vector3 position;
    //[SerializeField] private Transform startTransform;
    public bool isUpdatingXPosition;
    private bool isCornerTurnerVirgin;
    CheckPointManager checkPointManager;
    private int corner = 0;
    public GameObject[] CornerTurners;
    private Transform nextCornerTransform;


    // Start is called before the first frame update
    void Start()
    {
        //startTransform = GameObject.FindGameObjectWithTag("StartTransform").transform;
        isUpdatingXPosition = true;
        isCornerTurnerVirgin = true;
        checkPointManager = GameObject.FindGameObjectWithTag("CheckPointManager").GetComponent<CheckPointManager>();
        //currentCornerTransform = CornerTurners[corner].transform;
        GetHorizontalPosition();
    }

    // Update is called once per frame
    void Update()
    {

        SetHorizontalPosition();
    }



    void GetHorizontalPosition()
    {

        nextCornerTransform = CornerTurners[corner].transform;


        


        corner++;



        //if (isUpdatingXPosition)
        //{
        //    position = new Vector3(/*checkPointManager.lastCornerTurned.transform.position.x*/  GetComponent<PlayerMovement>().cornerTurner.transform.position.x , transform.position.y, transform.position.z);
        //}
        //else
        //{
        //    position = new Vector3(transform.position.x, transform.position.y, /*checkPointManager.lastCornerTurned.transform.position.z*/GetComponent<PlayerMovement>().cornerTurner.transform.position.z);

        //}
        //if (!isCornerTurnerVirgin)
        //{
        //    else
        //    {
        //        position = new Vector3(startTransform.position.x, transform.position.y, transform.position.z);
        //isCornerTurnerVirgin = false;
        //    }


        //}
    }




    void SetHorizontalPosition()
    {
        //if (isUpdatingXPosition)
        //{
        //    transform.position = new Vector3(nextCornerTransform.position.x, transform.position.y, transform.position.z);
        //}
        //else
        //{
        //    transform.position = new Vector3()
        //}
        
    }


}
