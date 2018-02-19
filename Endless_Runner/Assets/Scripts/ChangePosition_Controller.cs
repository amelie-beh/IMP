using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition_Controller : MonoBehaviour {

	public GameObject[] ObjectHolders;
		
	public void SetRandomActive () {
		int r = Random.Range (0, 5);
		if (ObjectHolders [r].activeInHierarchy == true) {
			SetRandomActive ();
		} else {
			ObjectHolders [r].SetActive (true);
			Debug.Log (r);
		}
	}
}