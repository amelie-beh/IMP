﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {

	private bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
	private bool isDraging = false;
	private Vector2 startTouch, swipeDelta;
	
	
	private void Update () {
		//when sombody touches the display set it true
		tap = swipeLeft = swipeRight = swipeUp = swipeDown = false;
		
		#region Standalone Inputs
		if(Input.GetMouseButtonDown(0)){
			tap = true;
			isDraging = true;
			startTouch = Input.mousePosition;
		} else if(Input.GetMouseButtonUp(0)){ //end of touch = false
			Reset();
			isDraging = false;
		}
		#endregion
		
		//duration of touch
		#region Mobile Inputs
		if(Input.touches.Length > 0){
			if(Input.touches[0].phase == TouchPhase.Began){
				isDraging = true;
				tap = true;
				startTouch = Input.touches[0].position;
			} else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled){
				Reset();
				isDraging = false;
			}
		}
		#endregion
		
		//Calculate the distance of the touch
		swipeDelta = Vector2.zero;
		if (isDraging){
			if(Input.touches.Length > 0){
				swipeDelta = Input.touches[0].position - startTouch;
			} else if (Input.GetMouseButton(0)){
				swipeDelta = (Vector2)Input.mousePosition - startTouch;
			}
		}
		//did we cross the deadzone? /zone that a touch is really a swipe
		if(swipeDelta.magnitude > 150){
			//wich direction?
			float x = swipeDelta.x;
			float y = swipeDelta.y;
			if (Mathf.Abs(x) > Mathf.Abs(y)){
				//left or right
				if(x < 0){
					swipeLeft = true;
				} else{
					swipeRight = true;
				}
			} else {
				//up or down
				if (y < 0){
					swipeDown = true;
				}else {
					swipeUp = true;
				}
			}
			
			Reset();
		}
	}
	//if touch ended do this
	private void Reset () {
		startTouch =  swipeDelta = Vector2.zero;
		isDraging = false;	
	}
	//Variables we need

	public bool Tap{get { return tap; }}
	public Vector2 SwipeDelta{get { return swipeDelta;} }
	public bool SwipeLeft {get {return swipeLeft; } }
	public bool SwipeRight {get {return swipeRight; } }
	public bool SwipeUp {get {return swipeUp; } }
	public bool SwipeDown {get {return swipeDown; } }
	
	
}