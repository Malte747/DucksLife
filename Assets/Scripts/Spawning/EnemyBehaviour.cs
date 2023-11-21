using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed = 5.0f; // Geschwindigkeit des NPC

    void Update()
    {
        // Bewege den NPC nach links basierend auf der Geschwindigkeit
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Überprüfen, ob der NPC außerhalb des Sichtfelds ist, und ihn zurücksetzen
        if (transform.position.x < -60f)
        {
           Destroy(gameObject);
        }
    }


    }

