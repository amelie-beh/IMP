using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Functions : MonoBehaviour {
	//All functions that are needed in the Menu
	public float startTime;
	public Text score;
	public Text endScore;
	public Canvas PauseCanvas;
	public Canvas EndScreenCanvas;
	public int t;
	public Slider audioSlider;
	public float audio;
	
	void Start () {
		audio = PlayerPrefs.GetFloat("Audio");
		audioSlider.value = audio;
		startTime = Time.time;
		Time.timeScale = 1;
		t = 0;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) { //for the back taste on the phone
			StartPause();
		 }
		 
		 //The shown highscore on the display
		 t = (int)(Time.time - startTime); 
		 score.text = t.ToString();
		 
		if(t > PlayerPrefs.GetInt("HS1")){ //Setting the highscore
			PlayerPrefs.SetInt("HS1", t);
		}
		endScore.text = ("Highscore = " + PlayerPrefs.GetInt("HS1").ToString() );
		}
	
	
	public void StartPause(){
		PauseCanvas.gameObject.SetActive(true);
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
		PauseCanvas.gameObject.SetActive(false);
		Time.timeScale = 1;
	}

	public void SliderIsUsed(){
		PlayerPrefs.SetFloat("Audio", audioSlider.value);
		PlayerPrefs.Save ();
	}
}
