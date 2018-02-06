using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Sphere : MonoBehaviour {
	
	public KeyCode moveL;
	public KeyCode moveR;
	
	public float horizVel = 0;
	public int laneNum = 2;
	public string controllocked = "n";
	
	public Swipe swipeControls;
	public Transform player;
	private Vector3 desiredPosition;
	
	void Start () {
		
	}
	
	void Update () {
		
		GetComponent<Rigidbody>().velocity = new Vector3 (horizVel, 0, 4);
		
		if (Input.GetKeyDown(moveL) || (swipeControls.SwipeLeft) && (laneNum>1)&& (controllocked== "n")){
			horizVel = -2;
			StartCoroutine (stopSlide());
			laneNum -= 1;
			controllocked = "y";
		}
		if (Input.GetKeyDown(moveR) || (swipeControls.SwipeRight) && (laneNum<3)&& (controllocked== "n")){
			horizVel = 2;
			StartCoroutine (stopSlide());
			laneNum += 1;
			controllocked = "y";
		}
	}
	IEnumerator stopSlide(){
		yield return new WaitForSeconds ( .5f);
		horizVel = 0;
		controllocked = "n";
	}
}
