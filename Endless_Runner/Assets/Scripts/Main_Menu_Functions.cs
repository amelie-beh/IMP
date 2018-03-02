﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu_Functions : MonoBehaviour {
	//Script for the Menu functions of the MainMenu
	public Slider audioSlider;
	public float audio;
	public Text score;
	
	public void Start(){
		audio = PlayerPrefs.GetFloat("Audio");
		audioSlider.value = audio;
		score.text = (PlayerPrefs.GetInt("HS1").ToString() );
	}
	
	public void StartGame(){
		SceneManager.LoadScene(1);
	}
	
	public void Quit(){
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit ();
		#endif
	}
	
	public void SliderIsUsed(){
		PlayerPrefs.SetFloat("Audio", audioSlider.value);
		PlayerPrefs.Save ();
	}
	
	public void StartTutorial(){
		SceneManager.LoadScene(2);
	}
	
}
