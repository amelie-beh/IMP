using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialText : MonoBehaviour {

	//If the player enters the trigger, the UI Text will be shown

	public GameObject text;

	void Start () {
		text.SetActive (false);
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			text.SetActive (true);
			StartCoroutine (SetInactive ());
		}
	}

	IEnumerator SetInactive() {
		yield return new WaitForSeconds(5);
		text.SetActive (false);
	}
}
