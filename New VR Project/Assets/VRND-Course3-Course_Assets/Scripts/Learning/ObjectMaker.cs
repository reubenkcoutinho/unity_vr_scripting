﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaker : MonoBehaviour {

	public GameObject objectToCreate;

	// Use this for initialization
	void Start () {
		//make object here
		for (int i = 0; i < 1000; i++) {
			Object.Instantiate(objectToCreate, new Vector3(2, i, 6), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
