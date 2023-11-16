using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropScript : MonoBehaviour
{
    public float speed = 5.0f; // Geschwindigkeit des NPC

    void Update()
    {
        // Bewege den NPC nach links basierend auf der Geschwindigkeit
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Überprüfen, ob der NPC außerhalb des Sichtfelds ist, und ihn zurücksetzen
        if (transform.position.y < -10f)
        {
            ResetNPCPosition();
        }
    }

    // Setze die Position des NPCs zurück, wenn er außerhalb des Sichtfelds ist
    void ResetNPCPosition()
    {
        transform.position = new Vector3(10f, 0f);
    }
      void OnTriggerEnter(Collider other)
    {
        // Wenn der Spieler mit einem Würfel kollidiert, zerstöre den Würfel.
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            
            Debug.Log("Win");
        }
    }
}

