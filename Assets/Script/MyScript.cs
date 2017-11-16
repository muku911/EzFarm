using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

    public GameObject[] bookPakcoy;

	public void pakcopedia()
    {
        bookPakcoy[0].gameObject.SetActive(true);
    }
    public void pngHama()
    {
        bookPakcoy[1].gameObject.SetActive(true);
    }
    public void pngPenyakit()
    {
        bookPakcoy[22].gameObject.SetActive(true);
    }
}
