using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMeshRenderer : MonoBehaviour {

	//this script is to set the mesh from the tapable objects enable and disable

	public HideTapObstacle hideTapObstacle;

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
