using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour {


	//public GameObject boarders;

	public float speed = 20f;
	private float camPosition;
	private float vSpeed;
	private bool cage = false;

	private bool upBoarder = false;
	private bool downBoarder = false;
	// Use this for initialization
	void Start () {
		camPosition = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		vSpeed = speed * Time.deltaTime;



		if (Input.GetAxis ("Mouse ScrollWheel") > 0f) { // forward
			if (!upBoarder) {
				transform.position = new Vector3 (transform.position.x, transform.position.y + (vSpeed * 0.1f), transform.position.z);
			}
		}
		if (Input.GetAxis ("Mouse ScrollWheel") < 0f) { // forward
			if (!downBoarder) {
				transform.position = new Vector3 (transform.position.x, transform.position.y - (vSpeed * 0.1f), transform.position.z);
			}
		}

	}
	public void OnTriggerExit(Collider coll){
		upBoarder = false;
		downBoarder = false;
	}
	public void OnTriggerEnter(Collider coll){
		cage = true;
		if (coll.gameObject.name == "boarderUp") {
			upBoarder = true;
		} else {
			downBoarder = true;
		}
	}
}
//name boarders to allow scroll after contact