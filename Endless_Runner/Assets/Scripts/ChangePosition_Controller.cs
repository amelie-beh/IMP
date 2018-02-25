using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition_Controller : MonoBehaviour {

	public GameObject[] ObstacleHolders;
		
	public void SetRandomActive () {
		int r = Random.Range (0, 5);
		if (ObstacleHolders [r].activeInHierarchy == true) {
			SetRandomActive ();
		} else {
			ObstacleHolders [r].SetActive (true);
			Debug.Log (r);
		}
	}
}