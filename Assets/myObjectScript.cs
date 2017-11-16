using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myObjectScript : MonoBehaviour {

    public int Number;
    public MyScript wpGGwp;

    public void closeItu()
    {
        wpGGwp.bookPakcoy[Number].gameObject.SetActive(false);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
