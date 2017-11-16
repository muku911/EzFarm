using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    public GameObject book;

    public void goHome()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void goPlayer()
    {
        SceneManager.LoadScene("Player Customize");
    }
    public void goPot1()
    {
        SceneManager.LoadScene("Quest");
    }

    public void enableBook()
    {
        book.gameObject.SetActive(true);
        Debug.Log("OpenBook");
    }

    public void disableBook()
    {
        book.gameObject.SetActive(false);
        Debug.Log("CloseBook");
    }

    public void resetPlayerPref()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Reseted");
    }

}
