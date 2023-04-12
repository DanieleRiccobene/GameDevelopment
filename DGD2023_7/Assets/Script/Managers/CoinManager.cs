using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    [SerializeField] int coins;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //SaveGame.SaveCoins(100);
        coins = SaveGame.GetCoins();
    }

    public void AddCoins(int coinsToAdd)
    {
        coins += coinsToAdd;
    }

    public void SaveCoins()
    {
        SaveGame.SaveCoins(coins);
    }
}
