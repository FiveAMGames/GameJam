using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {


	public GameObject nextStep;
	private bool onMouse = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButton && onMouse && nextStep!=null) {
			nextStep.SendMessage ("Go");
		}


	}
	public void OnMouseEnter(){
		onMouse = true;
	}
	public void OnMouseExit(){
		onMouse = false;
	}
}
