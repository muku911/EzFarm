using System.Collections;
using UnityEngine;

public class LoadNameDB : MonoBehaviour {
    /*[SerializeField]
    private Text playerText = null;
    [SerializeField]
    private Text levelText = null; */
    public int setplayer;
    public string[] Player;
    public static string playerName, playerLevelparse;
    public static int playerLevel;
    // Use this for initialization
    IEnumerator Start()
    {
        WWW PlayerData = new WWW("http://localhost/Ez_Farm/PlayerData.php");

        yield return PlayerData; //nunggu donlot data

        string PlayerDataTeks = PlayerData.text;
        //print(PlayerDataTeks);
        Player = PlayerDataTeks.Split(';');
        //print(GetDataValue(Player[setplayer], "Name:")); //ganti "Nama:" jadi kolom yg diinginkan
        getPlayerData();
        //playerText.text = playerName;
        //levelText.text = playerLevel.ToString();
        Debug.Log(PlayerPrefs.GetString("Name", playerName));
        Debug.Log(PlayerPrefs.GetInt("Level", playerLevel));
    }

    //memisahkan isi data berdasarkan pemisah "|"
    string GetDataValue(string data, string kolom) //data=player kolom=id/nama/level
    {
        string value = data.Substring(data.IndexOf(kolom) + kolom.Length);
        //memisahkan isi data berdasarkan pemisah "|"
        if (value.Contains("|"))
        {
            value = value.Remove(value.IndexOf("|"));
        }
        return value;
    }

    void getPlayerData()
    {
      //playerName = GetDataValue(Player[setplayer], "Name:");
      //int.TryParse (GetDataValue(Player[setplayer], "Level:"), out playerLevel);
        PlayerPrefs.SetString("Name", playerName);
        PlayerPrefs.SetInt("Level", playerLevel);
    }

}

