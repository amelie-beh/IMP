using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {

	private bool tap, swipeLeft, swiepeRight, swipeUp, swipeDown;
	private Vector2 startTouch, swipeDelta;
	

	
	public Vector2 SwipeDelta{get { return swipeDelta;} }
	public bool SwipeLeft {get {return swipeLeft; } }
	public bool SwipeRight {get {return swipeRight; } }
	public bool SwipeUp {get {return swipeUp; } }
	public bool SwipeDown {get {return swipeDown; } }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		tap = swipeLeft = swiepeRight = swipeUp = swipeDown = false;
		
		Standalone Inputs
		if(Input.GetMouseButtonDown(0)){
			tap = true;
			startTouch = Input.mousePosition;
		} else if(Input.GetMouseButtonUp(0)){
			Reset();
		}
	}
	
	private void Reset () {
		startTouch =  swipeDelta = Vector2.zero;
		
	}
}
