using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object : MonoBehaviour {

	//Object is moving in the direction of the player

	public float movementSpeed;

	void Update(){

		transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
	}
}