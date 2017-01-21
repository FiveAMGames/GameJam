using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board : MonoBehaviour {
	private bool moveOne = false;
	private bool moveTwo = false;


	public Transform targetOne;
	public Transform targetTwo;

	private Vector3 position;

	private float startPosition;
	private float endPosition;

	private bool loop = false;
	private bool ok = false;

	private Vector3 loopPositions;
	private bool here = false;
	// Use this for initialization
	void Start () {
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		//endPosition = Vector3 (startPosition.x + 10f, startPosition.y, startPosition.z);

		if (moveOne && !here && !ok) {
			transform.position =Vector3.MoveTowards (position, targetOne.position, Time.deltaTime*3f);
			position = transform.position;
			if (transform.position.x == targetOne.transform.position.x) {
				here = true;
				position = transform.position;
				Debug.LogFormat ("here");  //on the left side
			}
		}



		if (moveTwo && here && !loop) {
			transform.position = Vector3.MoveTowards(position, targetTwo.position, Time.deltaTime*3f);
			position = transform.position;
			if (transform.position.x == targetTwo.position.x) {
				ok = true;
				here = false;
				Debug.Log ("Ok Loop");
			}
		}
		if (ok && loop) {
			transform.position = Vector3.MoveTowards(position, loopPositions, Time.deltaTime*3f);
			position = transform.position;

			if (transform.position.x == loopPositions.x) {
				loop = false;
			}
		}





	}
	public void Go(){
		Debug.Log ("go");
		if (!moveOne) {
			moveOne = true;
		}
		if (moveOne && here) {
			Debug.Log ("Move two");
			moveTwo = true;

		}

		if (ok && !loop) {
			if (transform.position.x == targetOne.position.x) {
				loopPositions = targetTwo.position;
			} else {
				loopPositions = targetOne.position;
			}
			loop = true;
		}

	}

}
