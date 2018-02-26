using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition_ObstacleHolder : MonoBehaviour {

	// If ObstacleHolder is behind the player's sight, the position will be changed to create a loop of ObstacleHolders

	public GameObject[] obstacleHolders;
	public GameObject ObstacleHolderController;
	public ChangePosition_Controller changePostitionController;

	void Update () {
		for (int i = 0; i <= 9; i++) {
			if (obstacleHolders[i].transform.position.z <= -32) {
				obstacleHolders[i].transform.position = new Vector3 (0.5f, 3, 118);
				obstacleHolders[i].SetActive (false);
				changePostitionController = ObstacleHolderController.GetComponent<ChangePosition_Controller> ();
				changePostitionController.SetRandomActive ();
			}
		}
	}
}
