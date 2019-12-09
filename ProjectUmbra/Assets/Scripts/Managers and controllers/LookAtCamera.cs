using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        LookAtTarget();
    }

    void Update()
    {
        transform.position = followTarget.position + new Vector3(0, 3f, 0);
       
        if(ObjectHandeler.Alice.activeSelf == false || ObjectHandeler.Alice.activeSelf == false)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void LookAtTarget()
    {
        ResetRotation();

        switch (player.GetComponent<PlayerMovement>().cornerTurnerMode)
        {
            case 0:
                Debug.Log("Mode 0");
                if(SceneManager.GetActiveScene().name == "Whitebox_lvl1")
                {
                    transform.Rotate(0, -180, 0, Space.Self);
                }
                else
                {
                    transform.Rotate(0, 270, 0, Space.Self);
                }              
                break;
            case 1:
                Debug.Log("Mode 1");
                if (SceneManager.GetActiveScene().name == "Whitebox_lvl1")
                {
                    transform.Rotate(0, -90, 0, Space.Self);
                }
                else
                {
                    transform.Rotate(0, 0, 0, Space.Self);
                }
                break;
            case 2:
                Debug.Log("Mode 2");
                if (SceneManager.GetActiveScene().name == "Whitebox_lvl1")
                {
                    transform.Rotate(0, 0, 0, Space.Self);
                }
                else
                {
                    transform.Rotate(0, 90, 0, Space.Self);
                }
                break;
            case 3:
                Debug.Log("Mode 3");
                if (SceneManager.GetActiveScene().name == "Whitebox_lvl1")
                {
                    transform.Rotate(0, 90, 0, Space.Self);
                }
                else
                {
                    transform.Rotate(0, 180, 0, Space.Self);
                }
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
