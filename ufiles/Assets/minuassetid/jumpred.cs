using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class jumpred : MonoBehaviour {
    AudioSource jumpsound;
	// Use this for initialization
	void Start () {
        jumpsound = GameObject.Find("jumps").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D))
		{
			Vector2 jumpForce = new Vector2(100, 300);
			Debug.Log ("jumpright");
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
            jumpsound.Play();
		}
		if (Input.GetKeyDown (KeyCode.A))
		{
			Vector2 jumpForce = new Vector2(-100, 300);
			Debug.Log ("jumpleft");
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
            jumpsound.Play();
        }
	}
}
