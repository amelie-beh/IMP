using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEnd : MonoBehaviour {

	//If the player enters the trigger, the endscreen will be shown

	public Canvas EndScreenCanvas;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			EndScreenCanvas.gameObject.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
