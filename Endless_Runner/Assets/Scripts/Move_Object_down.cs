﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object_down : MonoBehaviour {

	//ObjectHolder bewegt sich in Richtung des Players
	public float movementSpeed;

	void Update(){

		transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
	}
}
