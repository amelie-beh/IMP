using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideUnderObject : MonoBehaviour {
	
	public Canvas EndScreenCanvas;

	void OnTriggerEnter(Collider other) {
		if(GameObject.Find("Sphere1").GetComponent<Move_Player>().isSliding==true){
			Debug.Log ("Juhu");
		} else {
			//EndScreenCanvas.gameObject.SetActive(true);
			//Time.timeScale = 0;
			Debug.Log("Game Over");
			
		}
	}
}
