using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHandeler : MonoBehaviour
{

    public static GameObject Set;
    public static GameObject Alice;
    public static GameObject[] ButtonList;
    public static GameObject Player;

    private void Awake()
    {


    }


    private void Start()
    {

        Player = GameObject.FindGameObjectWithTag("Player");
        Set = GameObject.FindGameObjectWithTag("Set");
        Alice = GameObject.FindGameObjectWithTag("Alice");

        if (Set != null && Alice != null){
            //Set.SetActive(false);
            //Alice.SetActive(false);
        }
        else
        {
            Debug.Log("dont have set and alice");
        }


        ButtonList = GameObject.FindGameObjectsWithTag("Button");
        Debug.Log(ButtonList.Length);

    }

    public static void SetActiveStatusForCompanions(bool status)
    {
        if(Set.activeSelf == true && Alice.activeSelf == true)
        { 
            Set.GetComponentInChildren<ParticleSystem>().Play();
            Set.SetActive(status);
            Alice.GetComponentInChildren<ParticleSystem>().Play();
            Alice.SetActive(status);
        } else if(Set.activeSelf == false && Alice.activeSelf == false)
        {
            Set.SetActive(status);
            Set.GetComponentInChildren<ParticleSystem>().Play();
            Alice.SetActive(status);
            Alice.GetComponentInChildren<ParticleSystem>().Play();
        }
    }

    


}
