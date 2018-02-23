using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideUnderObject : MonoBehaviour {
	//Script for the SlideUnder Enemies
	public Canvas EndScreenCanvas;

	void OnTriggerEnter(Collider other) { //Check if Player isSliding and end game if not
		if(GameObject.Find("Sphere1").GetComponent<Move_Player>().isSliding==true){
			Debug.Log ("Juhu");
		} else {
			EndScreenCanvas.gameObject.SetActive(true);
			Time.timeScale = 0;
			Debug.Log("Game Over");
			
		}
	}
}
