using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour
{
    public Transform startPosition;
    public Transform endPosition;
    public float movementSpeed = 5f;
    public float respawnDelay = 2f;

    private void Start()
    {
        // Set the initial position with a random Y-coordinate
        float randomY = Random.Range(4f, 11f); // Adjust the range as needed
        transform.position = new Vector3(startPosition.position.x, randomY, 22f);
    }

    private void Update()
    {
        // Move the object from right to left
        transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);

        // Check if the object has reached the end position
        if (transform.position.x <= endPosition.position.x)
        {
            // Despawn and respawn after a delay
            StartCoroutine(RespawnAfterDelay());
        }
    }

    private IEnumerator RespawnAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(respawnDelay);

        // Move the object back to the start position with a new random Y-coordinate
        float randomY = Random.Range(4f, 10f); // Adjust the range as needed
        transform.position = new Vector3(startPosition.position.x, randomY, 22f);
    }
}


