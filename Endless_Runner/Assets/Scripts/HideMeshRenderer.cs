using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMeshRenderer : MonoBehaviour {

	public HideTapObstacle hideTapObstacle;
		
	// Update is called once per frame
	void Update () {
		if (hideTapObstacle.isActive == false) {
			MeshRenderer m = gameObject.GetComponent<MeshRenderer> ();
			m.enabled = false;
		} else {
			MeshRenderer m = gameObject.GetComponent<MeshRenderer> ();
			m.enabled = true;
			
		}
		
	}
}
