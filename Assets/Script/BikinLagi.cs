using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikinLagi : MonoBehaviour {
    public Canvas cvs1, cvs2;
    public GameObject obj;
	// Use this for initialization
	void Start () {
        //btn = btn.GetComponent<Button>();
        cvs2.enabled = false;
	}

    public void butt()
    {
        cvs2.enabled = true;
        //btn.enabled = false;
    }
}
