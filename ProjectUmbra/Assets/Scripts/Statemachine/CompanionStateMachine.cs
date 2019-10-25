using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class CompanionStateMachine : MonoBehaviour
{
    //Attributes
    [SerializeField] private CompanionState[] states;

    private Dictionary<Type, CompanionState> stateDictionary = new Dictionary<Type, CompanionState>();
    private CompanionState currentState;
    private CompanionState lastState;
    private int stateID = 0;

    //Methods
    protected virtual void Awake()
    {
        foreach (CompanionState state in states)
        {
            CompanionState instance = Instantiate(state);
            instance.Initialize(this);
            stateDictionary.Add(instance.GetType(), instance);
            Debug.Log(instance + "added");
            if (currentState == null)
            {
                currentState = instance;
            }

            currentState.Enter();
        }
    }

    public void Transition<T>() where T : CompanionState
    {
        lastState = currentState;
        currentState.Exit();
        currentState = stateDictionary[typeof(T)];
        currentState.Enter();
    }

    public void TransitionBack()
    {
        CompanionState __lastState = currentState;

        currentState.Exit();
        currentState = lastState;
        currentState.Enter();

        lastState = __lastState;
    }

    protected virtual void FixedUpdate()
    {
        currentState.HandleFixedUpdate();
    }

    protected virtual void Update()
    {
        currentState.HandleUpdate();
    }

    //Getters and Setters
    public CompanionState GetLastState()
    {
        return lastState;
    }
}