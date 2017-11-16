using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GreenHouseScript : MonoBehaviour {

	public string BackScript;
    public string QuestName;

	// Use this for initialization
	void Start () {
		
	}
		
	
	// Update is called once per frame
	void Update () {

	}

	public void BackScene(){
        SceneManager.LoadScene(BackScript);
	}

    public void QuestScene()
    {
        SceneManager.LoadScene(QuestName);
    }


}
