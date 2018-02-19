using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOverObject : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if(GameObject.Find("Sphere1").GetComponent<Move_Player>().isJumping==true){
			Debug.Log ("Juhu");
		} else {
			Debug.Log ("Game End");
		}
	}
}
