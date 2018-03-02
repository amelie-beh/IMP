using System;
using System.Collections;
using UnityEngine;


public class CollisionChecker : MonoBehaviour {

	//This script is for checking collisions from player and objects with the enemy tag
	
	public Canvas endScreenCanvas;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Enemy") {
			endScreenCanvas.gameObject.SetActive(true);
			Time.timeScale = 0;
		}
	}
}
