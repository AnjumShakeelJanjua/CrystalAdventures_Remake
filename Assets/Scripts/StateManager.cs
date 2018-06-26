using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public State currentState;
    public State previousState;

    public bool ChangeState(State nextState)
    {
        if (currentState == null || (currentState.OnExit != null && currentState.OnExit(nextState)))
        {
            previousState = currentState;
            currentState = nextState;

            currentState.OnBegin();
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Update()
    {
        if (currentState != null && currentState.OnUpdate != null)
        {
            currentState.OnUpdate();
        }
    }
}
