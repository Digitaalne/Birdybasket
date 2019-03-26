using UnityEngine;
using System.Collections;
using UnityEngine.Audio;


public class pallscript : MonoBehaviour {
	public int siniskoor = 0;
	public int punaskoor = 0;
    AudioSource gctrl;
    void Start()
    {
        gctrl = GameObject.Find("gamecontrol").GetComponent<AudioSource>();
    }
	void OnCollisionEnter2D(Collision2D Ahvike)
	{
		Debug.Log (Ahvike.gameObject.name+ " Tere");
		//
		Collider2D collider = Ahvike.collider;
		//
		Vector2 kickforce = new Vector2 (300, 200);
		Vector2 kickforce2 = new Vector2 (-300, 200);
		Vector2 kickforce3 = new Vector2 (0, 100);
		Vector2 kickforce4 = new Vector2 (0, 250);

		
		
		//
		Vector3 contactPoint = Ahvike.contacts [0].point;
		Vector3 center = collider.bounds.center;
		bool right = contactPoint.x > center.x;
		bool top = contactPoint.y > center.y;
		if (Ahvike.gameObject.tag == "Player") {
			Debug.Log ("Kontakt");
			if (right == true) {
				GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				GetComponent<Rigidbody2D>().AddForce (kickforce);
				//Debug.Log ("Force added");
			} else if (right != true) {
				GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				GetComponent<Rigidbody2D>().AddForce (kickforce2);
				//Debug.Log ("Force added2");
			}
			if (top == true) {
				GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				GetComponent<Rigidbody2D>().AddForce (kickforce3);
				//Debug.Log ("Force added3");
			}
			if (top != true) {
				GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				GetComponent<Rigidbody2D>().AddForce (kickforce4);
				//Debug.Log ("Force added4");
			}
		} 
	
	}
	void OnTriggerEnter2D(Collider2D steam)
	{
		GameObject slind = GameObject.Find("sinilind");
		GameObject plind = GameObject.Find("punalind");
		//GameObject slind = GameObject.Find("sinilind");
		Debug.Log("CollisionTrigger");
		if (steam.gameObject.name== "PGoal")
		{
            gctrl.Play();
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,0f);
			gameObject.transform.position = new Vector3(-0.87f,-1.53f,0);
			slind.gameObject.transform.position = new Vector3(3.14f,0.08f,0);
			plind.gameObject.transform.position = new Vector3(-4.531f,0.08f,0);
			punaskoor +=1;

            
		}
		if (steam.gameObject.name == "VGoal")
		{
            gctrl.Play();
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,0f);
			gameObject.transform.position = new Vector3(-0.87f,-1.53f,0);

			slind.gameObject.transform.position = new Vector3(3.14f,0.08f,0);
			plind.gameObject.transform.position = new Vector3(-4.531f,0.08f,0);
			siniskoor +=1;
            

        }
	}
}
