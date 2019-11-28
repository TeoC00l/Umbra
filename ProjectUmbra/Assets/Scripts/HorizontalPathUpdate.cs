//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class HorizontalPathUpdate : MonoBehaviour
//{
//    Vector3 position;
//    [SerializeField] private Transform startTransform;
//    private bool isUpdatingXPosition;
//    private bool isCornerTurnerVirgin;
//    CheckPointManager checkPointManager;

//    // Start is called before the first frame update
//    void Start()
//    {
//        startTransform = GameObject.FindGameObjectWithTag("StartTransform").transform;
//        isUpdatingXPosition = true;
//        isCornerTurnerVirgin = true;
//        checkPointManager = GameObject.FindGameObjectWithTag("CheckPointManager").GetComponent<CheckPointManager>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        GetHorizontalPosition();
//        SetHorizontalPosition();
//    }

//    void GetHorizontalPosition()
//    {

//        if (!isCornerTurnerVirgin)
//        {
//            if (isUpdatingXPosition)
//            {
//                position = new Vector3(checkPointManager.lastCornerTurned.transform.position.x, transform.position.y, transform.position.z);
//                isUpdatingXPosition = false;
//            }
//            else
//            {
//                position = new Vector3(transform.position.x, transform.position.y, checkPointManager.lastCornerTurned.transform.position.z);
//                isUpdatingXPosition = true;

//            }
//        }
//        else
//        {
//            position = new Vector3(startTransform.position.x, transform.position.y, transform.position.z);
//            isCornerTurnerVirgin = false;
//        }
//    }

//    void SetHorizontalPosition()
//    {
//        transform.position = position;
//    }


//}
