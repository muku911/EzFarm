using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class QuestManager : MonoBehaviour {

    public QuestObject[] quest;
    public bool[] CompleteQuest;
    public Text text;

    int finalScore;
    int finalCoin;
    int finalXp;

    public int score, coin, xp;
   

    //EventBoolChange

    public void Quest1()
    {
        CompleteQuest[0] = true;
        quest_sukses();
        
    }

    public void Quest2()
    {
        CompleteQuest[1] = true;
        quest_sukses();
    }

    public void Quest3yes()
    {
        CompleteQuest[2] = true;
        quest_sukses();
    }

    public void Quest3no()
    {
        CompleteQuest[2] = true;
        quest_gagal();
    }

    public void Quest6()
    {
        CompleteQuest[5] = true;
        quest_sukses();

    }

    public void Quest7()
    {
        CompleteQuest[6] = true;
        quest_sukses();

    }


    // Use this for initialization
    void Start () {
        Application.runInBackground = true;
        CompleteQuest = new bool[quest.Length];
        loadPlayerprefs();
        finalScore = PlayerPrefs.GetInt("Score", 0);
        finalCoin = PlayerPrefs.GetInt("Coin", 0);
        finalXp = PlayerPrefs.GetInt("Xp", 0);
        Debug.Log(PlayerPrefs.GetInt("Score"));
        Debug.Log(PlayerPrefs.GetInt("Coin"));
        Debug.Log(PlayerPrefs.GetInt("Xp"));
    }

    private void loadPlayerprefs()
    {
        for (int i = 1; i <= CompleteQuest.Length; i++)
        {
            if (PlayerPrefs.GetInt("Quest" + i + "bool") == 1) CompleteQuest[i-1] = true; // 1 = true
            else CompleteQuest[i-1] = false;
        }
    }

    // Update is called once per frame
    void Update () {

    }
    void OnApplicationQuit()
    {
        savePlayerPrefs();
    }

    private void savePlayerPrefs()
    {
        for (int i = 1; i <= CompleteQuest.Length; i++) // 1 2 3
        {
            if (CompleteQuest[i-1] == true) PlayerPrefs.SetInt("Quest" + i + "bool", 1);
            else PlayerPrefs.SetInt("Quest" + i + "bool", 0);
        }
    }

    private void reset()
    {

    }
    public void quest_sukses()
    {
        Debug.Log("asd");
        tambahCoin();
        tambahScore();
        tambahXP();
        Debug.Log(PlayerPrefs.GetInt("Score"));
        Debug.Log(PlayerPrefs.GetInt("Coin"));
        Debug.Log(PlayerPrefs.GetInt("Xp"));
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
