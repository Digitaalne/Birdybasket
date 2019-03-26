using UnityEngine;
using System.Collections;

public class basketblock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void OnTriggerEnter2D(Collider2D noob)
	{
		Debug.Log(gameObject.name);
		if(noob.gameObject.tag=="Player")
		{
			if(gameObject.name == "VGoalblock")
			{
				noob.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,0f);
				noob.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(50,350));
			}
			if(gameObject.name == "PGoalblock")
			{
				noob.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,0f);
				noob.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-50,350));
			}
		}
	}
}
