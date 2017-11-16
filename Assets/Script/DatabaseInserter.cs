using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DatabaseInserter : MonoBehaviour {

    string formURL = ("http://localhost/Ez_Farm/InsertPlayerData.php");
    public int InputLevel = 1; //masih string perlu diganti ke desimal???
    public InputField Input;

    private string InputName;

    void Start()
    {
        if (PlayerPrefs.GetString("Name") != "") {
            SceneManager.LoadScene("MainMenu");
            print("Player is ready (" + PlayerPrefs.GetString("Name") + ")");
        } 
        else Input.text = PlayerPrefs.GetString("Name");
    }

    public void InputData() {
        InputName = Input.text;
        print(InputName); 
        //Give Score, Level, And Coin
        PlayerPrefs.SetInt("Level", 1);
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("Coin", 1000);
        print("New Player Get : \nCoins 1000 + Level 1 + Score 0");
        // CreatePlayer(InputName, InputLevel);
        storeData();
        SceneManager.LoadScene("MainMenu");
	}

    //store data to database
    public void CreatePlayer (string name, int level)
    {
        WWWForm form = new WWWForm();
        form.AddField("namePost", name);
        form.AddField("levelPost", level);

        WWW insertPlayerData = new WWW(formURL, form);
    }
    public void storeData()
    {
        PlayerPrefs.SetString("Name", InputName);
    }
}