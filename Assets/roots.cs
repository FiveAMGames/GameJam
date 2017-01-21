using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roots : MonoBehaviour {

	private bool checker = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Go(){
		Debug.Log ("Roots hear");
		
			GetComponent<Animator> ().SetTrigger ("Out");
		}

}
