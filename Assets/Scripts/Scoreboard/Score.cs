using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;

    public TMP_Text coinText;
    public int currentCoins;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        coinText.text = "Counter: " + currentCoins.ToString();
    }

    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "Counter: " + currentCoins.ToString();
    }
  
}
