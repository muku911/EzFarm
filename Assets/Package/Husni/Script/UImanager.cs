using UnityEngine;
using System.Collections;

public class UImanager : MonoBehaviour {

	public GameObject ShopPanel;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void clickOnShop(){
		ShopPanel.SetActive (true);
        print("Buka Toko");
	}

	public void clickCloseShop(){
		ShopPanel.SetActive (false);
        print("Tutup Toko");
	}
}
