using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object : MonoBehaviour {

	//Object is moving in the direction of the player

	private float movementSpeed = 4;

	void Update() {
		
		transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);

		if (Time.time >= 30) {
			movementSpeed = 5;
		}

		if (Time.time >= 60) {
			movementSpeed = 6;
		}

		if (Time.time >= 90) {
			movementSpeed = 7;
		}

		if (Time.time >= 120) {
			movementSpeed = 8;
		}

		if (Time.time >= 150) {
			movementSpeed = 9;
		}

		if (Time.time >= 180) {
			movementSpeed = 10;
		}

	}
}