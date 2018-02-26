using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object_Tutorial : MonoBehaviour {

	//Object is moving in the direction of the player

	private float movementSpeed = 4;

	void Update() {
		
		transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);

	}
}