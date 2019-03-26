using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	public GameObject sini;
	public GameObject ball;
	public float skohtx;
	public float skohty;
	public float bkohtx;
	public float bkohty;
	public SParem parem;
	public Svasak vasak;
	float aeg = 0.19f;
	bool hyppamine = true;

	// Use this for initialization
	void Start () {
		sini = GameObject.Find("sinilind");;
		ball = GameObject.Find ("pall");
		parem = sini.GetComponent<SParem>();
		vasak = sini.GetComponent<Svasak>();


    }
	
	// Update is called once per frame
	void Update () {
		skohtx = sini.gameObject.transform.position.x;
		skohty = sini.gameObject.transform.position.y;
		bkohtx = ball.gameObject.transform.position.x;
		bkohty = ball.gameObject.transform.position.y;
		aeg = aeg-Time.deltaTime;
		if(aeg <= 0 && hyppamine == true)
		{
			if (skohtx < bkohtx-1 && skohty < bkohty+1)
			{
				//Paremale
				parem.hyppe();
            }
			if (skohtx > bkohtx+1.8 && skohty < bkohty+1)
			{
				//vasakule
				vasak.hyppe();
			}
			aeg = 0.19f;
		}

	
	}
	void OnTriggerEnter2D(Collider2D ahv)
	{
		if(ahv.gameObject.name == "pall")
			hyppamine = false;
	}
	void OnTriggerExit2D(Collider2D ahv)
	{
		if(ahv.gameObject.name == "pall")
			hyppamine = true;
	}
}
