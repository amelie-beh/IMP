using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Functions : MonoBehaviour {
	//All functions that are needed in the Menu
	public float startTime;
	public Text scoreText;
	public Text endScore;
	public Canvas pauseCanvas;
	public int score;
	public Slider audioSlider;
	public float audio;
	
	void Start () {
		audio = PlayerPrefs.GetFloat("Audio");
		audioSlider.value = audio;
		startTime = Time.time;
		Time.timeScale = 1;
		score = 0;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) { //for the back taste on the phone
			StartPause();
		 }
		 
		 //The shown highscore on the display
		score = (int)(Time.time - startTime); 
		scoreText.text = score.ToString();
		if(score > PlayerPrefs.GetInt("HS1")){ //Setting the highscore
			PlayerPrefs.SetInt("HS1", score);
		}
		endScore.text = ("Highscore = " + PlayerPrefs.GetInt("HS1").ToString() );
		}
	
	
	public void StartPause(){
		pauseCanvas.gameObject.SetActive(true);
		Time.timeScale = 0;
	}
	
	public void GoTo_MainMenu(){
		SceneManager.LoadScene(0);
	}
	
	public void Quit(){
		#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit ();
		#endif
	}
	
	public void GoOn(){
		pauseCanvas.gameObject.SetActive(false);
		Time.timeScale = 1;
	}

	public void SliderIsUsed(){
		PlayerPrefs.SetFloat("Audio", audioSlider.value);
		PlayerPrefs.Save ();
	}
}
