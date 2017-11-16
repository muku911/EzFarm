using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    int finalScore;
    int finalCoin;
    int finalXp;

    public int score, coin, xp;

	// Use this for initialization
	void Start () {
        finalScore = PlayerPrefs.GetInt("Score", 0);
        finalCoin = PlayerPrefs.GetInt("Coin", 0);
        finalXp = PlayerPrefs.GetInt("Xp", 0);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void quest_sukses()
    {
        tambahCoin();
        tambahScore();
        tambahXP();
        Debug.Log("Total Score : " + PlayerPrefs.GetInt("Score"));
        Debug.Log("Total Coin : " + PlayerPrefs.GetInt("Coin"));
        Debug.Log("Total XP : " + PlayerPrefs.GetInt("Xp"));
    }

    public void quest_gagal()
    {
        kurangCoin();
        kurangScore();
        kurangXp();
        Debug.Log(PlayerPrefs.GetInt("Score"));
        Debug.Log(PlayerPrefs.GetInt("Coin"));
        Debug.Log(PlayerPrefs.GetInt("Xp"));
    }

    void tambahScore()
    {
        finalScore = finalScore + score;
        PlayerPrefs.SetInt("Score", finalScore);
    }

    void kurangScore()
    {
        finalScore = finalScore - score;
        PlayerPrefs.SetInt("Score", finalScore);
    }

    void tambahCoin()
    {
        finalCoin = finalCoin + coin;
        PlayerPrefs.SetInt("Coin", finalCoin);
    }

    void kurangCoin()
    {
        finalCoin = finalCoin - coin;
        PlayerPrefs.SetInt("Coin", finalCoin);
    }
    
    void tambahXP()
    {
        finalXp = finalXp + xp;
        PlayerPrefs.SetInt("Xp", finalXp);
    }

    void kurangXp()
    {
        finalXp = finalXp - xp;
        PlayerPrefs.SetInt("Xp", finalXp);
    }
}
