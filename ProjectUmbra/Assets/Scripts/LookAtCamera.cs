using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{

    Transform target;
    Transform followTarget;
    [SerializeField] private bool followAlice = false;
    


    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("MainCamera").transform;
        if (followAlice)
        {
            followTarget = ObjectHandeler.Alice.transform;
        }
        else
        {
            followTarget = ObjectHandeler.Set.transform;
        }
    }

    void Update()
    {
        transform.position = followTarget.position;
       
    }

    public void LookAtTarget(Transform targetPoint)
    {
        transform.LookAt(targetPoint);
    }
}
