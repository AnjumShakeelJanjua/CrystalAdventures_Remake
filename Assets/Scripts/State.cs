using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
	public string state_name;

	public delegate void BeginDelegate ();

	public delegate void UpdateDelegate ();

	public delegate bool ExitDelegate (State nextState);

	public BeginDelegate OnBegin;
	public UpdateDelegate OnUpdate;
	public ExitDelegate OnExit;

	//public State (string className)
	//{
		//state_name = className;
	//}
}
