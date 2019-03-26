using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class jumpblue : MonoBehaviour {

    AudioSource jumpsound;
    // Use this for initialization
    void Start () {
        jumpsound = GameObject.Find("jumps").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown (KeyCode.RightArrow))
			{
				Vector2 jumpForce = new Vector2(100, 300);
				Debug.Log ("jumprightblue");
				GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				GetComponent<Rigidbody2D>().AddForce(jumpForce);
                jumpsound.Play();
        }
			if (Input.GetKeyDown (KeyCode.LeftArrow))
			{
				Vector2 jumpForce = new Vector2(-100, 300);
				Debug.Log ("jumpleftblue");
				GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				GetComponent<Rigidbody2D>().AddForce(jumpForce);
                jumpsound.Play();
        }
	}
}
