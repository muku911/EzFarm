using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopNotifikasi : MonoBehaviour {
    public GameObject notif;

    public void notifikasi()
    {
        notif.SetActive(true);
    }
    public void TutupNotifikasi()
    {
        notif.SetActive(false);
    }

    public void back()
    {
        SceneManager.LoadScene("GreenHouse");
    }

    public void backMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
