using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject man;
	private Vector3 offset;


	// Use this for initialization
	void Start () {
		offset = transform.position - man.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = man.transform.position + offset;
	}
}
