using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFromPipe : MonoBehaviour {

	private bool go = false;
	private float t = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		t = Time.time;
		if (go && Time.time-t >10f) {
			GetComponent<Animator> ().SetBool ("Go", false);
			go = false;
			GetComponent<Renderer> ().enabled = true;
		}
	}

	public void Go(){
		GetComponent<Renderer> ().enabled = true;
		GetComponent<Animator> ().SetBool ("Go", true);
		if (!go) {
			go = true;
			t = Time.time;
		}
	}

	public void StopWatering(){
		
	}
}
