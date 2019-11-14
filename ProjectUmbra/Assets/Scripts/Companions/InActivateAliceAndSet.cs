using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InActivateAliceAndSet : MonoBehaviour
{

    private GameObject alice;
    private GameObject set;
    [SerializeField] private GameObject followerIcons;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {



            try { 
                ObjectHandeler.Alice.SetActive(false);
                ObjectHandeler.Set.SetActive(false);
                followerIcons.SetActive(false);
            }
            catch (System.NullReferenceException)
            {
                Debug.Log("deActivate set and alice FAIL");
            }
        }
    }


}
