using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveGame
{
    private static string coinKey = "COINS";
    

    public static void SaveCoins(int coins)
    {
        PlayerPrefs.SetInt(coinKey, coins);
        PlayerPrefs.Save();
    }

    public static int GetCoins()
    {
        return PlayerPrefs.GetInt(coinKey);
    }
}
