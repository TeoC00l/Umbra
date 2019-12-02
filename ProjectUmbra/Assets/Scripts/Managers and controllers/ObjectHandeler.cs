using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectHandeler : MonoBehaviour
{

    public static GameObject Set;
    public static GameObject Alice;
    public static GameObject[] ButtonList;
    public static GameObject Player;
    public static GameObject CheckPointManager;
    //public static GameObject SpeechBubble_Alice, SpeechBubble_Set;
    //public static TextMeshPro SpeechBubble_Alice_Text, SpeechBubble_Set_Text;

  


    private void Awake()
    {

        Player = GameObject.FindGameObjectWithTag("Player");
        Set = GameObject.FindGameObjectWithTag("Set");
        Alice = GameObject.FindGameObjectWithTag("Alice");
        CheckPointManager = GameObject.FindGameObjectWithTag("CheckPointManager");

        //SpeechBubble_Alice = GameObject.FindGameObjectWithTag("AliceSpeechBubble");
        //SpeechBubble_Set = GameObject.FindGameObjectWithTag("SetSpeechBubble");

        //SpeechBubble_Alice_Text = SpeechBubble_Alice.transform.GetChild(0).GetComponent<TextMeshPro>();
        //SpeechBubble_Set_Text = SpeechBubble_Set.transform.GetChild(0).GetComponent<TextMeshPro>();

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

    


}
