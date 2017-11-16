using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tanamanPerhari : MonoBehaviour {

    public Sprite[] pakzoy;
    public Image perHari;

    private int dayPakcoy;

    private float x, y;


    // Use this for initialization
    void Start () {

        
        dayPakcoy = PlayerPrefs.GetInt("pakcoyday");
        Ulala();
    }
	
	// Update is called once per frame
	void Update () {
        dayPakcoy = PlayerPrefs.GetInt("pakcoyday");
        
    }

    private void Ulala()
    {
        switch (dayPakcoy)
        {
                
            case 1:
                perHari.gameObject.SetActive(false);
                break;
            case 2:
                perHari.gameObject.SetActive(false);
                break;
            case 3:
                perHari.sprite = pakzoy[20];
                 x = 15;
                 y = 15;
                RectTransform perHariRec3 = perHari.GetComponent<RectTransform>();
                perHariRec3.sizeDelta = new Vector2(x, y);
                break;
            case 4:
                perHari.sprite = pakzoy[20];
                x = 15;
                y = 15;
                RectTransform perHariRec4 = perHari.GetComponent<RectTransform>();
                perHariRec4.sizeDelta = new Vector2(x, y);
                break;
            case 5:
                perHari.sprite = pakzoy[20];
                x = 15;
                y = 15;
                RectTransform perHariRec5 = perHari.GetComponent<RectTransform>();
                perHariRec5.sizeDelta = new Vector2(x, y);
                break;
            case 6:
                perHari.sprite = pakzoy[1];
                 x = 30;
                 y = 30;
                RectTransform perHariRec6 = perHari.GetComponent<RectTransform>();
                perHariRec6.sizeDelta = new Vector2(x, y);
                break;
            case 7:
                perHari.sprite = pakzoy[1];
                x = 30;
                y = 30;
                RectTransform perHariRec7 = perHari.GetComponent<RectTransform>();
                perHariRec7.sizeDelta = new Vector2(x, y);
                break;
            case 8:
                perHari.sprite = pakzoy[1];
                x = 30;
                y = 30;
                RectTransform perHariRec8 = perHari.GetComponent<RectTransform>();
                perHariRec8.sizeDelta = new Vector2(x, y);
                break;
            case 9:
                perHari.sprite = pakzoy[2];
                x = 35;
                y = 35;
                RectTransform perHariRec9 = perHari.GetComponent<RectTransform>();
                perHariRec9.sizeDelta = new Vector2(x, y);
                break;
            case 10:
                perHari.sprite = pakzoy[2];
                x = 35;
                y = 35;
                RectTransform perHariRec10 = perHari.GetComponent<RectTransform>();
                perHariRec10.sizeDelta = new Vector2(x, y);
                break;            
            case 11:
                perHari.sprite = pakzoy[3];
                x = 45;
                y = 45;
                RectTransform perHariRec11 = perHari.GetComponent<RectTransform>();
                perHariRec11.sizeDelta = new Vector2(x, y);
                break;

        }
    }
}
