using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Functions : MonoBehaviour {
	
	private float startTime;
	public Text score;
	public Text endScore;
	public Canvas PauseCanvas;
	public Canvas EndScreenCanvas;
	
	void Start () {
		startTime = Time.time;
		Time.timeScale = 1;
		
	}
	

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) { 
			StartPause();
		 }
		 //Der Angezeigte Highscore am Bildschirm
		 int t = (int)(Time.time - startTime); 
		 score.text = t.ToString();
		 
		 
		 if(EndScreenCanvas.enabled){
			 if(t > PlayerPrefs.GetInt("HS1")){
				 PlayerPrefs.SetInt("HS1", t);
			 }
			endScore.text = ("Nummer 1 = " + PlayerPrefs.GetInt("HS1").ToString() );
			t = PlayerPrefs.GetInt("HS1");
		 }
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
}
