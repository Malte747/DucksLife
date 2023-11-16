using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleVariableAndDebug : MonoBehaviour
{
	// For initialization your variables need to be placed here at the beginning of the class
	// initialization of varibles with different data types and values, each line a new variable
	public int myFirstInteger = 10;
	public int mySecondInteger = 20;
	public int myThirdInteger;

	public float myFirstFloat = 10.5f;
	public float mySecondFloat = 2665.5f;

	public string myFirstText = "Mein erster Text!";

	public bool myFirstBool;


	// Start is called before the first frame update, when you press the "PLAY" button in Unity
	void Start()
	{
		// For calculation on runtime, place the debug.log scripts in the Start method here below
 
		// Example to output one variable with Debug.Log
		Debug.Log(myFirstInteger);
		Debug.Log(myFirstInteger);
		
		// Example to output multiple variables with one Debug.Log, the " " are to create a space between the variable
		Debug.Log(myFirstText + " " + myFirstFloat + " " + mySecondFloat);
		Debug.Log(myFirstText + myFirstFloat + mySecondInteger);

		// Example to calculate the first and second integer and store it in the third int variable
		// the following Debug.Log can display the calculation
		myThirdInteger = myFirstInteger +  mySecondInteger;
		Debug.Log(myThirdInteger);

		// Example of adding 10 to the third integer variable
		myThirdInteger += 10; 

		// Example to print the updated calculated variable with additional text help identify the variable in the console
		Debug.Log("Neu Neu Neu " + myThirdInteger);
	}
}
