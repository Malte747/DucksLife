using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryDebug : MonoBehaviour
{





    // Start is called before the first frame update
    void Start()
    {

        // Das kommt immer am Anfang, egal was du tust

        Debug.Log("Ich versteh das alles nicht");
        Debug.LogError("Looooool");
        Debug.LogWarning("Sei gewarnt");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Warum tust du nix?");
        
    }
}
