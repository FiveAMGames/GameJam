using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roots : MonoBehaviour {

	public GameObject rootsWater;
	public GameObject ladder;

	cat catScript;

	private bool checker = false;
	// Use this for initialization
	void Start () {
		catScript = GameObject.Find ("cat").GetComponent<cat> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Go(){

		if (catScript.rootsTime) {

			Debug.Log ("Roots aaaa");
		
			GetComponent<Animator> ().SetTrigger ("Out");
			//GameObject.Find ("ladder").SendMessage ("Activate");
			ladder.gameObject.GetComponent<ladder>().ok = true;
		}
	}

	public void WaterOut(){
		rootsWater.SetActive (true);
	}

}
