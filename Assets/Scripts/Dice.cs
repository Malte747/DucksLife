using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int diceNumber;

 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
    }

    void RollDice()
    {
        // Erzeugen einer zufälligen Zahl zwischen 1 und 6 
        diceNumber = Random.Range(1, 7);

        // Debug-Ausgabe der gewürfelten Zahl in die Konsole
        Debug.Log("Geworfene Zahl: " + diceNumber);
    }
}

