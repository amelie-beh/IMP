using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideUnderObject : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if(GameObject.Find("Sphere1").GetComponent<Move_Player>().isSliding==true){
			Debug.Log ("Juhu");
		} else {
			Debug.Log("Game Over");
		}
	}
}
