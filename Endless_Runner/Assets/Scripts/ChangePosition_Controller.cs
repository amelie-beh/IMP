using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition_Controller : MonoBehaviour {

	// This script is for setting a random ObstacleHolder as active

	public GameObject[] obstacleHolders;
	public int randomNumber;
		
	public void SetRandomActive () {
		randomNumber = Random.Range (0, 10);
		if (obstacleHolders [randomNumber].activeInHierarchy == true) {
			SetRandomActive ();
		} else {
			obstacleHolders [randomNumber].SetActive (true);
		}
	}
}