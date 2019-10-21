//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CornerTurner2 : MonoBehaviour
//{
//    [SerializeField] private GameObject player;
//    private Transform rotation0;
//    private Transform rotation1;
//    private int currentRotation;
//    private PlayerMovement pm;

//    // Start is called before the first frame update
//    void Start()
//    {
//        pm = player.GetComponent<PlayerMovement>();
//        currentRotation = 0;
//    }

//    private void OnTriggerEnter(Collider other)
//    {

//        if (other.CompareTag("Player"))
//        {
//            pm.SetControlled(false);
//            pm.rb.isKinematic = true;

//            if (currentRotation == 0)
//            {
//                other.transform.localRotation = Quaternion.Euler(0f, -90f, 0f);

//                currentRotation = 1;

//            }
//            else
//            {
//                other.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);

//                currentRotation = 0;
//            }
//        }
//    }
//}
