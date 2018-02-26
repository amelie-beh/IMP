using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTapObstacle : MonoBehaviour {

	//If the object is clicked five times, it will be set as inactive
	//After 5 seconds it will be set active again

	private int count = 0;
	public bool isActive = true;

	void OnMouseDown() {
		count++;
		if (count == 5) {
			isActive = false;
			Collider c = gameObject.GetComponent<BoxCollider> ();
			c.enabled = false;
			StartCoroutine (SetActiveAgain ());
		}
	}

	IEnumerator SetActiveAgain() {
		yield return new WaitForSeconds(5);
		isActive = true;
		Collider c = gameObject.GetComponent<BoxCollider> ();
		c.enabled = true;
	}
}
