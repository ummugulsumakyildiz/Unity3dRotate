using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundCamera : MonoBehaviour {

	public GameObject target;
	private float speedMod = 10.0f;
	private Vector3 point;

	// Use this for initialization
	void Start () {
		point = target.transform.position;
		transform.LookAt (point);
	}

	// Update is called once per frame
	void Update () {
		transform.RotateAround (target.transform.position,  Vector3.up, speedMod * Time.deltaTime);
	}
}
