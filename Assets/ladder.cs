using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour {


	public bool ok = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Go (){
		Debug.Log ("Ladder");
		if (ok) {
			GameObject.Find ("cat").SendMessage ("LadderTime");
		}

	}
}
