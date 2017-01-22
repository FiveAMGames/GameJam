using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterTower : MonoBehaviour {

	public GameObject waterPipe;
	private float t = 0f;

	private bool check;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time - t > 30f && check) {
			waterPipe.SetActive (false);
			check = false;
		}

	}
	public void Go (){
		waterPipe.SetActive (true);
		t = Time.time;
		check = true;

	}
}
