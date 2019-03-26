using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pause : MonoBehaviour {

	GameObject menyy;
	Vector3 vanapos;
	// Use this for initialization
	RectTransform ahv;
	void Start()
	{
		menyy = GameObject.Find("pausemenu");
		 ahv = menyy.GetComponent<RectTransform>();
		vanapos = ahv.localPosition;
		
	}
	private int loendaja = 0;
	public void stop()
	{



		if (loendaja == 0)
		{
			ahv.localPosition = new Vector3(1.2f, 1.2f, 1.2f);
			Time.timeScale = 0;
			loendaja +=1;

		}
		else
		{
			Time.timeScale = 1;
			loendaja = 0;
			ahv.localPosition = vanapos;
		}
		
	}
}
