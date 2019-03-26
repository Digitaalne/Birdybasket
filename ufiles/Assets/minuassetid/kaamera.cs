using UnityEngine;
using System.Collections;

public class kaamera : MonoBehaviour {
	
	// Use this for initialization
	float defaultSize = 4f/3f;
	
	void Start ()
	{
		GetComponent<Camera>().orthographicSize = defaultSize/ GetComponent<Camera>().aspect * GetComponent<Camera>().orthographicSize;
	}
	
}
