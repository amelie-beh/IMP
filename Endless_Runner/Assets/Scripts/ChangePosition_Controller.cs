using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition_Controller : MonoBehaviour {

	// This script is for setting a random ObstacleHolder as active

	public GameObject[] ObstacleHolders;
		
	public void SetRandomActive () {
		int r = Random.Range (0, 10);
		if (ObstacleHolders [r].activeInHierarchy == true) {
			SetRandomActive ();
		} else {
			ObstacleHolders [r].SetActive (true);
			Debug.Log (r);
		}
	}
}