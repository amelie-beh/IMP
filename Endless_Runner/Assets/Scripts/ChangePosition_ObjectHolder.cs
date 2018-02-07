using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition_ObjectHolder : MonoBehaviour {

	public GameObject objectHolder;

	// If ObjectHolder is behind the player's sight, the position will be changed to create a loop of ObjectHolders
	void Update () {

		if (transform.position.z < 0) {
			objectHolder.transform.position = new Vector3(0.5f, 3, 36);
		}
	}
}
