using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour {

	public float DelayTime;
	private string NextScene;
    private string NamePlayer;
    private float timer;

    // Use this for initialization
    void Start() {
        NamePlayer = PlayerPrefs.GetString("Name");
        Debug.Log("Player Name: " + NamePlayer);
        NextScene = "Input Profil";
        print("Goto Input Profil");
     
    }
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > DelayTime) {
			SceneManager.LoadScene (NextScene);
		}
	}


}

