﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Enemy") {
			Debug.Log ("Game End");
		}
	}
}
