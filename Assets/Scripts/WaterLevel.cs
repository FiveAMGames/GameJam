using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevel : MonoBehaviour {

	public GameObject waterLevel;
	float m;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = waterLevel.transform.position;
		m = waterLevel.transform.position.y + 1.5f;
	}
	
	// Update is called once per frame
	void Update () {



		if (pos.y < m) {

			waterLevel.transform.position = Vector3.MoveTowards (pos, new Vector3 (waterLevel.transform.position.x, waterLevel.transform.position.y + 1.5f, waterLevel.transform.position.z), Time.deltaTime * 0.5f);
			pos = waterLevel.transform.position;
			if (waterLevel.transform.position == pos) {
				GameObject.Find ("cat").SendMessage ("WaterLevelUp");
			}
		}

	}

	public void Go(){
		Debug.Log ("Water");

	}
}
