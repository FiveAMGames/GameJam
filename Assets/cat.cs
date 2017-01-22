using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour {


	public Transform outCage;
	public Transform onBoard;
	public Transform rightSide;
	public Transform pipeBlock;


	private bool outCageBool = false; 
	private bool boardOn = false;
	private bool waterLevel = false;
	private bool ladder = false;


	board boardScript;
	private Vector3 position;

	public bool canGo = false;
	public bool rootsTime = false;

	Animator anim;

	// Use this for initialization
	void Start () {
		boardScript = GameObject.Find ("board").GetComponent<board> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (outCageBool) {
			canGo= false;
			//anim.SetBool ("Walk", true);
			transform.position = Vector3.MoveTowards (transform.position, new Vector3 (outCage.position.x, transform.position.y, transform.position.z), Time.deltaTime *1f);
			if (transform.position.x == outCage.position.x) {
				anim.SetBool ("Walk", false);
				canGo = true;
				position = transform.position;
				outCageBool = false;
			}
		}

		if (boardScript.leftSide && canGo ) {
			boardScript.stop = true;
			transform.position = Vector3.MoveTowards (position, onBoard.position, Time.deltaTime * 5f);
			position = transform.position;

			if (transform.position == new Vector3 (onBoard.position.x, onBoard.position.y, position.z)) {
				canGo = false;
				boardOn = true;
				gameObject.transform.SetParent (onBoard);
				boardScript.stop = false;

			}
		}

		if (waterLevel && boardScript.rightSide && boardOn == true) {
			if (gameObject.transform.parent != null) {//boardFree = true;
				gameObject.transform.parent = null;
				transform.position = onBoard.transform.position;
			} else {
				position = transform.position;
				transform.position = Vector3.MoveTowards (position, rightSide.position, Time.deltaTime * 5f);


				if (transform.position == new Vector3 (rightSide.position.x, rightSide.position.y, rightSide.position.z)) {
					canGo = false;
					boardOn = false;
					rootsTime = true;


				}
			}
		}

		if (ladder) {
			transform.position = pipeBlock.position;
		}




		
	}

	public void OutCage(){
		outCageBool = true;
		anim.SetBool ("Walk", true);
	}

	public void WaterLevelUp(){
		waterLevel = true;
	}

	public void LadderTime(){
		ladder = true;
	}


}
