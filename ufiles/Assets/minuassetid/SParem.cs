using UnityEngine;
using System.Collections;

public class SParem : MonoBehaviour {
    AudioSource jumpsound;
    void Start()
    {
        jumpsound = GameObject.Find("jumps").GetComponent<AudioSource>();
    }
    public void hyppe()
	{
        jumpsound.Play();
        Vector2 jumpForce = new Vector2(150, 265);

		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		GetComponent<Rigidbody2D>().AddForce(jumpForce);
	}
}
