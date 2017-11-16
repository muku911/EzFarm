using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseLoader : MonoBehaviour {
    public string[] Player;
    public static string playerName;
	// Use this for initialization
	IEnumerator Start () {
        WWW PlayerData = new WWW("http://localhost/Ez_Farm/PlayerData.php");

        yield return PlayerData; //nunggu donlot data

        string PlayerDataTeks = PlayerData.text;
        //print(PlayerDataTeks);
        Player = PlayerDataTeks.Split(';');
        print(GetDataValue(Player[0], "Name:")); //ganti "Nama:" jadi kolom yg diinginkan
        getPlayerData();
        print(playerName);
    }

    //memisahkan isi data berdasarkan pemisah "|"
    string GetDataValue (string data, string kolom) //data=player kolom=id/nama/level
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
        playerName = ("QWERTY");
       // playerName = GetDataValue(Player[0], "Name:");
    }
	
}
