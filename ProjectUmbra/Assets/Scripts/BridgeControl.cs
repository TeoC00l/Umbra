using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeControl : MonoBehaviour
{
    private void Update()
    {
        
        if (transform.localEulerAngles.z > 80f)
        {
            Debug.Log("destroy joint");
            Destroy(this.GetComponent<HingeJoint>());
            
        }
    }
}
