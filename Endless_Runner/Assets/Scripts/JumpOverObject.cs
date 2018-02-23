using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOverObject : MonoBehaviour {
	//Script for JumpOver Enemies
	public Canvas EndScreenCanvas;

	void OnTriggerEnter(Collider other) {  //Check if Player isJumping and end game if not
		if(GameObject.Find("Sphere1").GetComponent<Move_Player>().isJumping==true){
			Debug.Log ("Juhu");
		} else {
			EndScreenCanvas.gameObject.SetActive(true);
			Time.timeScale = 0;
			Debug.Log ("Game End");
		}
	}
}
