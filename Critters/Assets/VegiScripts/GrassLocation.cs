﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassLocation : MonoBehaviour {

	// Use this for initialization
	public List<Vector3> grasses;
	public GameObject grass;
	void Start () {
		grasses = new List<Vector3> ();
		grasses.Add (grass.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
