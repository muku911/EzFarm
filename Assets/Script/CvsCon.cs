using UnityEngine;


public class CvsCon : MonoBehaviour {
    public Canvas BukuPanduan, pakcopedia;

	// Use this for initialization
	void Start () {
        pakcopedia.enabled = false;
       BukuPanduan.enabled = false;
	}

    public void butt() {
        BukuPanduan.enabled = true;
    }

    public void pakcoped() {
        BukuPanduan.enabled = false;
        pakcopedia.enabled = true;
    }
}
