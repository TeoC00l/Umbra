using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerTurner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody playerRb;

    private PlayerMovement pm;
    Vector3 currentInput = Vector3.zero;
    [SerializeField] private List<Transform> pathTransforms;
    [SerializeField]private Animation anim;
    private Animator Animator;
    [SerializeField] private GameObject target;
    private bool move = false;

    private float counter = 0f;

    private void Start() {
        pm = player.GetComponent<PlayerMovement>();
        //playerRb = player.GetComponent<Rigidbody>();
        //Animator = player.GetComponent<Animator>();
        //target = this.gameObject.transform.GetChild(2).gameObject;
    }

    private void checkDirection()
    {
        //currentInput = pm.getInput();
        //if (currentInput = ) ;
    }


    private void followCurve()
    {
       
    }

    private void Update()
    {
        //if (move && player.transform.position.x != target.transform.position.x)
        //{
        //    Vector3 targetDir = target.transform.position - player.transform.position;
        //    player.transform.position = Vector3.MoveTowards(player.transform.position, target.transform.position, (2f * Time.deltaTime));
        //    Vector3 newDir = Vector3.RotateTowards(player.transform.forward, targetDir, 2f * Time.deltaTime, 0.0f);
        //    player.transform.rotation = Quaternion.LookRotation(newDir);
        //    counter = counter + Time.deltaTime;
        //}
        //else
        //{
        //    counter = 0;
        //    move = false;
        //}
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            //move = true;
            //Vector3 targetDir = target.transform.position - player.transform.position;
            ////Debug.Log(pm.getInput());
            //Animator.SetTrigger("TurnCorner");
            //player.transform.position = Vector3.MoveTowards(player.transform.position, target.transform.position, (2f * Time.deltaTime));
            //Vector3 newDir = Vector3.RotateTowards(player.transform.forward, targetDir, 2f * Time.deltaTime, 0.0f);
            //player.transform.rotation = Quaternion.LookRotation(newDir);

            pm.setLocked();

        }

        //Vector3.MoveTowards(pathTransforms[i])

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Animator.SetTrigger("TurnCorner");
            //move = false;
            //pm.setLocked();
        }
    }
}
