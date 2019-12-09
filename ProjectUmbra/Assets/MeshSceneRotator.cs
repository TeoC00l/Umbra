using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshSceneRotator : MonoBehaviour
{
    public int cornerTurnerMode;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<PlayerMovement>().cornerTurnerMode = this.cornerTurnerMode;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RotateOnInitialize()
    {
        
    }
}
