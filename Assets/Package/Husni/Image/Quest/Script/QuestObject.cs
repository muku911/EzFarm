using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class QuestObject : MonoBehaviour {

    public int NumberQuest;
    private bool changeValueurutan;

    public QuestManager QM;
    public tanamanPerhari tP;
    public Text TestTing;

    private int score, x;

    private string _1stTimePlant, timeNow;
    private int dateNow;


    private int b = 18;

    // Use this for initialization
    void Start () {
        changeValueurutan = true;
        Application.runInBackground = true;
        // PlayerPrefs.SetString("Game Start", System.DateTime.Now.ToString("dd/MM/yyyy"));  // new game
        _1stTimePlant = PlayerPrefs.GetString("Game Start");

        setAktifQuest();
        checkQuest();

    }

    private void setAktifQuest()
    {
        //for time
        dateNow = PlayerPrefs.GetInt("pakcoyday");
        timeNow = PlayerPrefs.GetString("DayChange");
        //end

        switch (dateNow)
        {
            case 1:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[3].gameObject.SetActive(false);
                QM.quest[4].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 2:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[3].gameObject.SetActive(false);
                QM.quest[4].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 3:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[3].gameObject.SetActive(false);
                QM.quest[4].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 4:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[3].gameObject.SetActive(false);
                QM.quest[4].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 5:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[3].gameObject.SetActive(false);
                QM.quest[4].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 6:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 7:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 8:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 9:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 10:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 11:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 12:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 13:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 14:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 15:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 16:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 17:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 18:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 19:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 20:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 21:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                QM.quest[6].gameObject.SetActive(false);
                
                break;
            case 22:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 23:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 24:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 25:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 26:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 27:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                break;
            case 28:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 29:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 30:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 31:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 32:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 33:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 34:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 35:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 36:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 37:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 38:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 39:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 40:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 41:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 42:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 43:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 44:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 45:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 46:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 47:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 48:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 49:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
            case 50:
                QM.quest[NumberQuest].gameObject.SetActive(true);
                QM.quest[2].gameObject.SetActive(false);
                QM.quest[5].gameObject.SetActive(false);
                
                break;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        checkQuest();
        //for time
        dateNow = PlayerPrefs.GetInt("pakcoyday");
        timeNow = PlayerPrefs.GetString("DayChange");
        //end
        TestTing.text = _1stTimePlant + "\n" + PlayerPrefs.GetString("DayChange");

        

    }

    public void checkQuest()
    {
        if (QM.CompleteQuest[NumberQuest] == true)
        {
            QM.quest[NumberQuest].gameObject.SetActive(false);
        }
        
    }
}
