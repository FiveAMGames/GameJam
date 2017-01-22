using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorForCat : MonoBehaviour {

	public GameObject cat;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Cat(){
		cat.SendMessage ("OutCage");
	}
}
