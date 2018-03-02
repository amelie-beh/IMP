using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition_ObjectHolder : MonoBehaviour {
	
	// If ObjectHolder is behind the player's sight, the position will be changed to create a loop of ObjectHolders

	public GameObject[] objectHolders;
	private float newPosition;

	void FixedUpdate () {
		for (int i = 0; i < 3; i++) {
			if (objectHolders[i].transform.position.z <= -32) {
				if (i == 0) {
					newPosition = objectHolders [2].transform.position.z + 50;
					objectHolders [i].transform.position = new Vector3 (0.5f, 3, newPosition);
				} 
				if (i == 1) {
					newPosition = objectHolders [0].transform.position.z + 50;
					objectHolders [i].transform.position = new Vector3 (0.5f, 3, newPosition);
				}
				if (i == 2) {
					newPosition = objectHolders [1].transform.position.z + 50;
					objectHolders [i].transform.position = new Vector3 (0.5f, 3, newPosition);
				}
			}
		}
	}
}