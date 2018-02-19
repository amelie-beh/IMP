using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object_xx : MonoBehaviour {

	//ObjectHolder bewegt sich in Richtung des Players
	public float movementSpeed;

	void Update(){

		transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
	}
}
