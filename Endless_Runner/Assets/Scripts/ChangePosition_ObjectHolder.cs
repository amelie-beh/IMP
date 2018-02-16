using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition_ObjectHolder : MonoBehaviour {

	public GameObject[] objectHolders;
	public GameObject ObjectHolderController;
	public ChangePosition_Controller changePostitionController;

	// If ObjectHolder is behind the player's sight, the position will be changed to create a loop of ObjectHolders
	void Update () {
		for (int i = 0; i <= 4; i++) {
			int j = i % 4;
			if (objectHolders[j].transform.position.z <= 0) {
				objectHolders[j].transform.position = new Vector3 (0.5f, 3, 54);
				objectHolders[j].SetActive (false);
				changePostitionController = ObjectHolderController.GetComponent<ChangePosition_Controller> ();
				changePostitionController.SetRandomActive ();
			}
		}
	}
}
