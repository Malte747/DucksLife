using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public GameObject cubePrefab; 
    public float intervalBetweenCubes = 3f; 
    public Transform position1; 
    public Transform position2; 

    void Start()
    {
        // Starte das Erstellen der Würfel in Intervallen.
        InvokeRepeating("CreateCube", 0f, intervalBetweenCubes);
    }

    void CreateCube()
    {
        // Erstelle einen Würfel an einer der beiden Positionen
        GameObject cube = Instantiate(cubePrefab, RandomPosition(), Quaternion.identity);
    }

    Vector3 RandomPosition()
    {
        // Wähle zufällig zwischen den beiden Positionen.
        if (Random.Range(0, 2) == 0)
        {
            return position1.position;
        }
        else
        {
            return position2.position;
        }
    }


  
}

