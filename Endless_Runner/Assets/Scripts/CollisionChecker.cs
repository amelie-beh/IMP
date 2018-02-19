using System;
using System.Collections;
using UnityEngine;


public class CollisionChecker : MonoBehaviour {
	
	public Canvas EndScreenCanvas;
	

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Enemy") {
			EndScreenCanvas.gameObject.SetActive(true);
			Time.timeScale = 0;
			Debug.Log ("Game End");
		}
	}
}
