using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone_Objects : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DeathComponent dc = ObjectHandeler.Player.GetComponent<DeathComponent>();
            dc.RespawnPlayer();
        }
    }
}
