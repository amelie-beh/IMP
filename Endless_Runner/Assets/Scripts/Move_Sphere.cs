using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Sphere : MonoBehaviour {
	//First try of a moving script
	private Rigidbody player;
	
	public float z = -4;
	public float horizVel = 0;
	public int laneNum = 0;
	public float jump = 4.5f;
	public string controllocked = "n";
	public Swipe swipeControls;
	
	public Vector3 newPostition;
	
	void Start () {
		player = GetComponent<Rigidbody>();
		
	}
	void Update () {
		player.velocity = new Vector3(laneNum, 0f, 0f);
		// the instructions what to do when it was swiped
		
		if ((swipeControls.SwipeLeft)&&(laneNum >= 0)&&(controllocked== "n")){
			//horizVel = -1;
			StartCoroutine (stopSlide());
			controllocked = "y";
			laneNum--;
			
		}
		if ((swipeControls.SwipeRight)&&(laneNum <= 0)&&(controllocked== "n")){
			//horizVel = 1;
			StartCoroutine (stopSlide());
			controllocked = "y";
			laneNum++;
			transform.position = new Vector3(laneNum, jump, z);
		}
		if ((swipeControls.SwipeUp)&&(controllocked== "n")){
			//horizVel = 1;
			StartCoroutine (stopSlide());
			controllocked = "y";
			//newPostition.y = 10;
			player.velocity= new Vector3(laneNum, 0.2f, 0f);
			jump = 5.5f;
		}
		
		transform.position = new Vector3(laneNum, jump, z);
		//Vector3 newPostition = transform.position;
		//newPostition.x = laneNum;
		//transform.position = newPostition;
		
	}
	
	IEnumerator stopSlide(){
		yield return new WaitForSeconds (0.7f);
		//horizVel = 10;
		controllocked = "n";
		player.velocity= new Vector3(laneNum, 0.5f, 0f);
		jump = 4.5f;
	}
}

		//X  Left and right
		//Y Up and down
		//Z Forward and backwards
		
