using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour {

	public string ForButtonStart;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void quitAplication(){
		Application.Quit();
	}

	public void startBtn(){
        SceneManager.LoadScene(ForButtonStart);
	}
}
