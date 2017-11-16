using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameStart : MonoBehaviour
{

    public Text Score, dayNow;
    public QuestManager QM;
    public int dayTester;
    private int score = 0;
    private int pakcoyTime = 50, pakcoyDay = 0, blyat;
    private string timeDay;
    private bool toNextDay = false;
    private float timer, Delaytime;


    // Use this for initialization
    void Start()
    {
        dayTester = PlayerPrefs.GetInt("pakcoyday");
        Application.runInBackground = true;
        if (PlayerPrefs.GetString("Game Start") == null)
            PlayerPrefs.SetString("Game Start", DateTime.Now.ToString("dd/MM/yyyy"));
       
        // for day change effect
        pakcoyDay = PlayerPrefs.GetInt("pakcoyday");
        if (pakcoyDay == 0)
        {
            pakcoyDay = 1;
            PlayerPrefs.SetInt("pakcoyday", pakcoyDay);
        }

        dayTester = pakcoyDay;
        Delaytime = 1;

        //string to int
        //int.TryParse();
        //testdoang
    }
    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("pakcoyday", dayTester);
        dayTester = PlayerPrefs.GetInt("pakcoyday");
        //for time
        dayNow.text = PlayerPrefs.GetInt("pakcoyday").ToString();
        PlayerPrefs.SetString("Date Time", DateTime.Now.ToString("dd/MM/yyyy"));
        PlayerPrefs.SetString("DayChange", DateTime.Now.ToString("HH:mm:ss"));
        //end time
        //buat besok
        timeDay = PlayerPrefs.GetString("DayChange"); 
        string nextDay = PlayerPrefs.GetString("DayChange");
        if (timeDay == "23:59:59") {
            timer += Time.deltaTime;
            if (timer > Delaytime)
            {
                dayTester++;
            }
            QM.CompleteQuest[0] = false;
            QM.CompleteQuest[1] = false;
            QM.CompleteQuest[2] = false;
            QM.CompleteQuest[3] = false;
            QM.CompleteQuest[4] = false;
            QM.CompleteQuest[5] = false;
            QM.CompleteQuest[6] = false;
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("pakcoyday", dayTester);
    }

}
 
