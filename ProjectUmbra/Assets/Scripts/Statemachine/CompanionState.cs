using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionState : ScriptableObject
{
    //Methods
    public virtual void Initialize(CompanionStateMachine owner) { }
    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void HandleUpdate() { }
    public virtual void HandleFixedUpdate() { }
}