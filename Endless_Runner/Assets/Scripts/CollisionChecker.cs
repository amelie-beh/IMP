using System;
using System.Collections;
using UnityEngine;


public class CollisionChecker : MonoBehaviour {
	

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Enemy") {
			Debug.Log ("Game End");
		}
	}
}
