using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class InpupDataTinggidanJumlahDaun : MonoBehaviour {

    public GameObject inputTinggiTanaman, inputJumlahDaunTanaman;
    public Text DataInputTinggi, DataInputDaun;
    public QuestManager QM;

    int finalScore;
    int finalCoin;
    int finalXp;

    public int score, coin, xp;

    public void inputTinggi()
    {
        inputTinggiTanaman.SetActive(true);
        DataInputTinggi.text = PlayerPrefs.GetInt("TinggiTanaman").ToString();
    }

    public void inputJumlahDaun()
    {
        inputJumlahDaunTanaman.SetActive(true);
        DataInputDaun.text = PlayerPrefs.GetInt("JumlahDaun").ToString();

    }

    public void inputTinggiDone()
    {
        int textTinggi;
        int.TryParse(DataInputTinggi.text, out textTinggi);
        if (textTinggi != 0)
        {
            PlayerPrefs.SetInt("TinggiTanaman", textTinggi);
            inputTinggiTanaman.SetActive(false);
            QM.CompleteQuest[3] = true;
            quest_sukses();
        }
    }

    public void inputJumlahDaunDone()
    {
        int textDaun;
        int.TryParse(DataInputDaun.text, out textDaun);
        if (textDaun != 0)
        {
            PlayerPrefs.SetInt("JumlahDaun", textDaun);
            inputJumlahDaunTanaman.SetActive(false);
            QM.CompleteQuest[4] = true;
            quest_sukses();
        }
    }

    // Use this for initialization
    void Start ()
    {
        Application.runInBackground = true;
        init();
	}

    private void init()
    {
        DataInputTinggi.text = PlayerPrefs.GetInt("TinggiTanaman").ToString();
        DataInputDaun.text = PlayerPrefs.GetInt("JumlahDaun").ToString();
    }

    // Update is called once per frame
    void Update () {
	
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
