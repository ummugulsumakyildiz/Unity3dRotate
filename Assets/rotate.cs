using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
	public GameObject man;
	float speed;
	float rotatex;
	private readonly string  mousex="Mouse X";
	// Use this for initialization
	void Start () {
		speed = 1000;
	}
	
	// Update is called once per frame
	void Update () {
		
		rotatex = Input.GetAxis (mousex) * speed * Mathf.Deg2Rad;
		transform.RotateAround (man.transform.position, Vector3.up, rotatex);
	}

}
