using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ObjectHandeler : MonoBehaviour
{

    public static GameObject Set;
    public static GameObject Alice;
    public static GameObject[] ButtonList;
    public static GameObject[] PressurePadList;
    public static GameObject Player;
    public static GameObject CheckPointManager;
    public static GameObject[] Boxes;
    public static GameObject DeathScreen;


    private void Awake()
    {

        Player = GameObject.FindGameObjectWithTag("Player");
        Set = GameObject.FindGameObjectWithTag("Set");
        Alice = GameObject.FindGameObjectWithTag("Alice");
        CheckPointManager = GameObject.FindGameObjectWithTag("CheckPointManager");
        Boxes = GameObject.FindGameObjectsWithTag("Grabbable");
        DeathScreen = GameObject.FindGameObjectWithTag("DeathScreen");

        if (Set != null && Alice != null){
            //Set.SetActive(false);
            //Alice.SetActive(false);
        }
        else
        {
            Debug.Log("dont have set and alice");
        }


        ButtonList = GameObject.FindGameObjectsWithTag("Button");
        //Debug.Log(ButtonList.Length + ": Buttons with mulipleBools");

        //PressurePadList = GameObject.FindGameObjectsWithTag("PressurePad");
        //Debug.Log(PressurePadList.Length + ": PressurePads");

        Physics.IgnoreCollision(Player.GetComponent<CapsuleCollider>(), Set.GetComponent<BoxCollider>());
        Physics.IgnoreCollision(Player.GetComponent<CapsuleCollider>(), Alice.GetComponent<BoxCollider>());
        Physics.IgnoreCollision(Set.GetComponent<BoxCollider>(), Alice.GetComponent<BoxCollider>());

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


    public static void ResetBoxes()
    {
        foreach (GameObject box in Boxes)
        {
            box.GetComponent<BoxSpawn>().RespawnBox();
            Debug.Log("BoxREspawn");
        }
    }


    


}
