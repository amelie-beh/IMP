using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Player : MonoBehaviour {
	//Script for the movement of the Player
	
	private Rigidbody player;
	public float jumpHeight = -3f;
	public float zPosition = -4;
	public float laneNum = 0f;
	public bool controllocked = false;
	public Swipe swipeControls;
	public bool isSliding; 
	public bool isJumping;
	public float horizVel = 0;
	
	void Start () {
		player = GetComponent<Rigidbody>();	
		}
	
	void Update () {//Description what to do when the swipe input comes
		player.velocity = new Vector3(horizVel, jumpHeight, 0f);
		//Go left
		if ((swipeControls.SwipeLeft)&&(laneNum >= 0)&&(controllocked== false)){
			laneNum--;
			horizVel = -3.3f;
			controllocked = true;
			StartCoroutine(stopSlideToSide());
		}
		//Go right
		if ((swipeControls.SwipeRight)&&(laneNum <= 0)&&(controllocked== false)){
			horizVel = 3.4f;
			controllocked = true;
			laneNum++;
			StartCoroutine(stopSlideToSide());	
		}
		//Jump
		if ((swipeControls.SwipeUp)&&(controllocked== false)){
			controllocked = true;
			jumpHeight = 3f;
            StartCoroutine(startJump());
			isJumping = true;
		}
		//Slide
		if ((swipeControls.SwipeDown)&&(controllocked== false)){
			controllocked = true;
			isSliding = true;
			jumpHeight = -3f;
			transform.localScale = new Vector3(0.78f, 0.55f, 0.55f);  //Change the appearance
			StartCoroutine(stopSliding());
		}
	}
	//Control of the player timewise 
	IEnumerator startJump(){
        yield return new WaitForSeconds(0.5F);
        jumpHeight = -3.5f;
		StartCoroutine(stopJump());	
	}
	
	IEnumerator stopJump(){
        yield return new WaitForSeconds(0.5F);
        controllocked = false;
		jumpHeight = 0f;
		isJumping = false;
		transform.position = new Vector3(laneNum, 4.37f, zPosition);	
	}
	
	IEnumerator stopSlideToSide(){
        yield return new WaitForSeconds(0.3F);
        horizVel = 0;
        controllocked = false;
		transform.position = new Vector3(laneNum, 4.37f, zPosition);
	}
	
	IEnumerator stopSliding(){
        yield return new WaitForSeconds(0.85F);
		transform.localScale = new Vector3(0.75f, 0.75f,0.75f);
        isSliding = false;
		jumpHeight = 0f;
		controllocked = false;
	}
	
}
