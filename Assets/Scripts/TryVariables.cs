using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryVariables : MonoBehaviour
{

    public int Klaus = 5;
    public int Hans = 3;
    public int Ole = 2;
    public int Malte = 13;
    public int Rolf = 22;

    public int Lösung;
    public string Sag = "Oder wie ein Kenner sagen Würde";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Das Ergebnis dieser Rechnung ist" + " " + (Klaus + Hans + Ole + Malte + Rolf)/3);

        Lösung = (Klaus + Hans + Ole + Malte + Rolf)/3;
        Debug.Log(Sag + " " + Lösung);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
