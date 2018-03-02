using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideUnderObject : MonoBehaviour {
	//Script for the SlideUnder Enemies
	public Canvas endScreenCanvas;

	void OnTriggerEnter(Collider other) { //Check if Player isSliding and end game if not
		if(GameObject.Find("Sphere1").GetComponent<Move_Player>().isSliding==false){
			endScreenCanvas.gameObject.SetActive(true);
			Time.timeScale = 0;	
		} 
	}
}
