using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{

    Transform target;
    Transform followTarget;
    [SerializeField] private bool followAlice = false;
    private GameObject player;
    private Quaternion originalRotation, mode0, mode1, mode2, mode3;

    private void Start()
    {
        player = ObjectHandeler.Player;
        target = GameObject.FindGameObjectWithTag("MainCamera").transform;
        if (followAlice)
        {
            followTarget = ObjectHandeler.Alice.transform;
        }
        else
        {
            followTarget = ObjectHandeler.Set.transform;
        }

        originalRotation = Quaternion.Euler(0, 0, 0);
        mode3 = Quaternion.Euler(0, 180, 0);
        mode2 = Quaternion.Euler(0, 90, 0);
        mode1 = Quaternion.Euler(0, 0, 0);
        mode0 = Quaternion.Euler(0, 270, 0);

        LookAtTarget();
    }

    void Update()
    {
        transform.position = followTarget.position + new Vector3(0, 3f, 0);
       
    }

    public void LookAtTarget()
    {
        ResetRotation();
        //transform.LookAt(targetPoint);
        switch (player.GetComponent<PlayerMovement>().cornerTurnerMode)
        {
            case 0:
                Debug.Log("Mode 0");
                transform.Rotate(0, 270, 0, Space.Self);
                //transform.rotation = mode0;
                break;
            case 1:
                Debug.Log("Mode 1");
                transform.Rotate(0, 0, 0, Space.Self);
                //transform.rotation = mode1;
                break;
            case 2:
                Debug.Log("Mode 2");
                transform.Rotate(0, 90, 0, Space.Self);
                //transform.rotation = mode2;
                break;
            case 3:
                Debug.Log("Mode 3");
                transform.Rotate(0, 180, 0, Space.Self);
                //transform.rotation = mode3;
                break;
            default:
                Debug.Log("Default");
                break;
        }
            
     }

    public void ResetRotation()
    {
        transform.rotation = originalRotation;
    }
}
