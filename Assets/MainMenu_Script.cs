using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        SceneManager.LoadScene("GreenHouse");
        print("Play Clicked");
    }

    public void Setting()
    {
        print("Setting Clicked");
    }

    public void Exit()
    {
        SceneManager.LoadScene("SplashScreen");
        print("Exit Clicked");
    }

    public void ResetDataSave()
    {
        PlayerPrefs.DeleteAll();
        print("RESETED");
    }

}
