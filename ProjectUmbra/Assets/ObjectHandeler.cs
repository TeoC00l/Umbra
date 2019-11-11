using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHandeler : MonoBehaviour
{

    public static GameObject Set;
    public static GameObject Alice;


    private void Awake()
    {


    }


    private void Start()
    {
        Set = GameObject.FindGameObjectWithTag("Set");
        Alice = GameObject.FindGameObjectWithTag("Alice");

        if (Set != null && Alice != null){
            Set.SetActive(false);
            Alice.SetActive(false);
        }
        else
        {
            Debug.Log("dont have set and alice");
        }
    }


}
