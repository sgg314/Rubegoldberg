using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; 

public class finalTrigger : MonoBehaviour {

	public Text winText;		// The text space that will display "You Won".

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Object entered the trigger");
		winText.text = "THE END"; 
	}

	void OnTriggerStay (Collider other)
	{
		Debug.Log ("Object is in the trigger");
		winText.text = "THE END"; 
	}

	void OnTriggerExit (Collider other)
	{
		Debug.Log ("Object exited the trigger");
	}
}
