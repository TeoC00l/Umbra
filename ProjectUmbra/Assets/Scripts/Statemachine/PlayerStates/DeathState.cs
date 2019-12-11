using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/DeathState")]
public class DeathState : BaseState
{

    public override void Enter()
    {

        animator.SetTrigger("isDying 0");
    }

    public override void HandleUpdate()
    {


    }
    public override void HandleFixedUpdate()
    {
    }

    public override void Exit()
    {

        animator.SetBool("isIdle", true);
    }




}
