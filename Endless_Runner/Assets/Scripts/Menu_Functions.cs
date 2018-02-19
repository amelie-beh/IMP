using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Functions : MonoBehaviour {
	
	private float startTime;
	public Text score;
	public Canvas PauseCanvas;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) { 
			StartPause();
		 }
		 int t = (int)(Time.time - startTime); 
		 score.text = t.ToString();
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
