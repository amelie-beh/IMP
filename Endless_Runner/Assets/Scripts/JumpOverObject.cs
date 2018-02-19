using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOverObject : MonoBehaviour {
	
	public Canvas EndScreenCanvas;

	void OnTriggerEnter(Collider other) {
		if(GameObject.Find("Sphere1").GetComponent<Move_Player>().isJumping==true){
			Debug.Log ("Juhu");
		} else {
			EndScreenCanvas.enabled = true;
			Time.timeScale = 0;
			Debug.Log ("Game End");
		}
	}
}
