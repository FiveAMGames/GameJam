using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour {


	public Transform outCage;
	public Transform onBoard;
	public Transform rightSide;



	private bool outCageBool = false; 
	private bool boardOn = false;
	private bool waterLevel = false;



	board boardScript;
	private Vector3 position;

	public bool canGo = false;
	public bool rootsTime = false;

	// Use this for initialization
	void Start () {
		boardScript = GameObject.Find ("board").GetComponent<board> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (outCageBool) {
			canGo= false;
			transform.position = Vector3.MoveTowards (transform.position, new Vector3 (outCage.position.x, transform.position.y, transform.position.z), Time.deltaTime *1f);
			if (transform.position.x == outCage.position.x) {
				canGo = true;
				position = transform.position;
				outCageBool = false;
			}
		}

		if (boardScript.leftSide && canGo ) {
			transform.position = Vector3.MoveTowards (position, onBoard.position, Time.deltaTime * 1f);
			position = transform.position;

			if (transform.position == new Vector3 (onBoard.position.x, onBoard.position.y, position.z)) {
				canGo = false;
				boardOn = true;
				gameObject.transform.SetParent (onBoard);
			}
		}

		if (waterLevel && boardScript.rightSide && boardOn == true) {
			if (gameObject.transform.parent != null) {//boardFree = true;
				gameObject.transform.parent = null;
				transform.position = onBoard.transform.position;
			} else {
				position = transform.position;
				transform.position = Vector3.MoveTowards (position, rightSide.position, Time.deltaTime * 1f);


				if (transform.position == new Vector3 (rightSide.position.x, rightSide.position.y, rightSide.position.z)) {
					canGo = false;
					boardOn = false;
					rootsTime = true;


				}
			}
		}




		
	}

	public void OutCage(){
		outCageBool = true;
	}

	public void WaterLevelUp(){
		waterLevel = true;
	}
}
