using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Functions : MonoBehaviour {
	
	public Canvas PauseCanvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) { 
			StartPause();
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
