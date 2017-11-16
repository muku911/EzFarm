using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataSementara : MonoBehaviour {
    [SerializeField]
    private Text playerText = null;
    [SerializeField]
    private Text levelText = null;
    [SerializeField]
    private Text scoreText = null;
    [SerializeField]
    private Text coinText = null;
    [SerializeField]
    private Text xpText = null;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        playerText.text = PlayerPrefs.GetString("Name");
        levelText.text = PlayerPrefs.GetInt("Level").ToString();
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
        coinText.text = PlayerPrefs.GetInt("Coin").ToString();
        xpText.text = PlayerPrefs.GetInt("Xp").ToString();
    }
}
