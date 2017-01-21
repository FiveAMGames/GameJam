using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrant : MonoBehaviour {

	public GameObject myWater;
	private bool checker = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Go(){
		if (!checker) {
			checker = true;
		} else {
			myWater.SendMessage ("Go");

		}
	}
}
