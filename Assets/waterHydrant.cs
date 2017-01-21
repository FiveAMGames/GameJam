using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterHydrant : MonoBehaviour {


	public GameObject roots;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Go (){
		GetComponent<Renderer> ().enabled = true;
		GetComponent<Animator> ().SetTrigger ("Go");
	}

	public void RootsGrow(){
		roots.SetActive (true);
		//roots.GetComponent<Renderer> ().enabled = true;
	}
}
