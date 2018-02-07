using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemies : MonoBehaviour {

	private int count = 0;

	void OnMouseDown() {
		count++;
		if (count == 5) {
			Destroy (gameObject);
		}
	}
}
