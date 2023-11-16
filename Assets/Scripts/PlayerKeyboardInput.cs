using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardInput : MonoBehaviour
{
    public float jumpHeight = 1.0f; // Sprunghöhe

    private bool isMovingUp = false;  // Ist der Spieler in Bewegung nach oben?
    private bool isMovingDown = false;  // Ist der Spieler in Bewegung nach unten?

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isMovingUp && !isMovingDown)
            {
                // Der Spieler bewegt sich nach oben, wenn er nicht bereits in Bewegung ist
                transform.Translate(Vector3.up * jumpHeight);
                isMovingUp = true;
            }
            else if (isMovingUp)
            {
                // Der Spieler bewegt sich nach unten, wenn er bereits nach oben bewegt wurde
                transform.Translate(Vector3.down * jumpHeight);
                isMovingUp = false;
                isMovingDown = true;
            }
            else if (isMovingDown)
            {
                // Der Spieler bewegt sich nach oben, wenn er bereits nach unten bewegt wurde
                transform.Translate(Vector3.up * jumpHeight);
                isMovingDown = false;
                isMovingUp = true;
            }
        }
    }
}

