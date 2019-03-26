using UnityEngine;
using System.Collections;

public class basketsounds : MonoBehaviour {
    AudioSource bounce;
    AudioSource hit;
	// Use this for initialization
	void Start () {
        bounce = GameObject.Find("bounce").GetComponent<AudioSource>();
        hit = GameObject.Find("hitsound").GetComponent<AudioSource>();
    }	

	void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.name.Contains("lind"))
        {
            bounce.Play();
        }
        else
        {
            hit.Play();
        }
    }
}
