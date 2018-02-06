using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Sphere : MonoBehaviour {
	
	public float horizVel = 0;
	public int laneNum = 0;
	public string controllocked = "n";
	
	public Swipe swipeControls;
	
	void Start () {
	}
	
	void Update () {
		//X - Left and right
		//Y Up and down
		//Z Forward and backwards
		
		if ((swipeControls.SwipeLeft)&&(laneNum >= 0)&&(controllocked== "n")){
			horizVel = -1;
			StartCoroutine (stopSlide());
			controllocked = "y";
			laneNum--;
			Debug.Log(laneNum);
		}
		if ((swipeControls.SwipeRight)&&(laneNum <= 0)&&(controllocked== "n")){
			horizVel = 1;
			StartCoroutine (stopSlide());
			controllocked = "y";
			laneNum++;
			Debug.Log(laneNum);
		}
		Vector3 newPostition = transform.position;
		newPostition.x = laneNum;
		transform.position = newPostition;
	}
	IEnumerator stopSlide(){
		yield return new WaitForSeconds (0.2f);
		horizVel = 10;
		controllocked = "n";
	}
}
