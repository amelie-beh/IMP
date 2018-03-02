using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition_ObstacleHolder : MonoBehaviour {
	
	public GameObject[] obstacleHolders;
	public GameObject obstacleHolderController;
	public ChangePosition_Controller changePositionController;
	private int random1;
	private int random2;
	private int random3;

	//Setting three random ObstacleHolders as active to start the game and set the start positions
	void Start() {
		changePositionController.SetRandomActive ();
		random1 = changePositionController.randomNumber;
		obstacleHolders[random1].transform.position = new Vector3 (0.5f, 3, 18);
		changePositionController.SetRandomActive ();
		random2 = changePositionController.randomNumber;
		obstacleHolders[random2].transform.position = new Vector3 (0.5f, 3, 68);
		changePositionController.SetRandomActive ();
		random3 = changePositionController.randomNumber;
		obstacleHolders[random3].transform.position = new Vector3 (0.5f, 3, 118);
	}

	// If ObstacleHolder is behind the player's sight, the position will be changed to create a loop of ObstacleHolders
	void Update () {
		for (int i = 0; i <= 9; i++) {
			if (obstacleHolders[i].transform.position.z <= -32) {
				obstacleHolders[i].transform.position = new Vector3 (0.5f, 3, 118);
				obstacleHolders[i].SetActive (false);
				changePositionController = obstacleHolderController.GetComponent<ChangePosition_Controller> ();
				changePositionController.SetRandomActive ();
			}
		}
	}
}
