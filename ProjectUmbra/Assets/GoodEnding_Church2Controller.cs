using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoodEnding_Church2Controller : MonoBehaviour
{

    public string sceneToChangeTo = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TriggerNextScene()
    {
        ObjectHandeler.DeathScreen.GetComponent<DeathscreenTimer>().FadeAndChangeScene(sceneToChangeTo);
    }
}
