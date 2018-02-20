﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Player : MonoBehaviour {
	
	private Rigidbody player;
	
	public float jumpHeight = -3f;
	
	public float z = -4;
	public float laneNum = 0;
	public string controllocked = "n";
	public Swipe swipeControls;
	public bool isSliding; 
	public bool isJumping;
	
	public float horizVel = 0;
	
	void Start () {
		player = GetComponent<Rigidbody>();
		
	}
	
	void Update () {
		player.velocity = new Vector3(horizVel, jumpHeight, z);
		
		if ((swipeControls.SwipeLeft)&&(laneNum >= 0)&&(controllocked== "n")){
			laneNum--;
			horizVel = -3.3f;
			controllocked = "y";
			StartCoroutine(stopSlide());
		}
		if ((swipeControls.SwipeRight)&&(laneNum <= 0)&&(controllocked== "n")){
			horizVel = 3.4f;
			controllocked = "y";
			laneNum++;
			StartCoroutine(stopSlide());	
		}
		if ((swipeControls.SwipeUp)&&(controllocked== "n")){
			controllocked = "y";
			jumpHeight = 3f;
            StartCoroutine(startJump());
			isJumping = true;
		}
		if ((swipeControls.SwipeDown)&&(controllocked== "n")){
			controllocked = "y";
			isSliding = true;
			//animation
			StartCoroutine(stopSliding());
		}
	}
	IEnumerator startJump(){
        yield return new WaitForSeconds(0.5F);
        jumpHeight = -3.5f;
		StartCoroutine(stopJump());
		
	}
	IEnumerator stopJump(){
        yield return new WaitForSeconds(0.5F);
        controllocked = "n";
		isJumping = false;
		transform.position = new Vector3(laneNum, 4.37f, z);	
	}
	IEnumerator stopSlide(){
        yield return new WaitForSeconds(0.3F);
        horizVel = 0;
        controllocked = "n";
		transform.position = new Vector3(laneNum, 4.37f, z);
		Debug.Log(laneNum);
	}
	IEnumerator stopSliding(){
        yield return new WaitForSeconds(0.5F);
        isSliding = false;
		controllocked = "n";
	}
	
}


		//X  Left and right
		//Y Up and down
		//Z Forward and backwards
