using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class GameControll : MonoBehaviour {

	pallscript palliskoor1;
	Text stekst;
	Text ptekst;
    int count = 0;
	float aeg = 3;
	Text l6pptekst;
	int adcounter;
    bool ad = false;
    string winner = "";
    void Start () {
		GameObject stekst1 = GameObject.Find("bskoor");
		stekst = stekst1.GetComponent<Text>();
		GameObject ptekst1 = GameObject.Find("rscore");
		ptekst = ptekst1.GetComponent<Text>();
		GameObject ltekst = GameObject.Find ("l6pptekst");
		l6pptekst = ltekst.GetComponent<Text>();
		GameObject palliskoor2 = GameObject.Find("pall");
		palliskoor1 = palliskoor2.GetComponent<pallscript>();

	}
	void Update()
	{
		int sskoor = palliskoor1.siniskoor;
		int pskoor = palliskoor1.punaskoor;


		stekst.text = sskoor.ToString();
		ptekst.text = pskoor.ToString();
		if(sskoor >= 5)
		{
			l6pptekst.text = "Blue Wins";
			l6pptekst.color = Color.blue;

			aeg = aeg-Time.deltaTime;
			if(aeg <= 0)
			{
                winner = "AI";
                Analyze();
                Ad();
                
                
			}
		}
		if(pskoor >= 5)
		{
			l6pptekst.text = "Red Wins";
			l6pptekst.color = Color.red;
			aeg = aeg-Time.deltaTime;
			if(aeg <= 0)
			{
                winner = "Human";
                Analyze();
                Ad();
                
                
            }
		}
        if(ad == true)
        {
            if(Advertisement.isShowing == false)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
	}
    void Ad()
    {

        adcounter = GameObject.Find("adcounter").GetComponent<adcount>().counter;
        
        if (count == 0)
        {
            if (adcounter < 4)
            {
                Advertisement.Show();
            }
            ad = true;
            count++;
            GameObject.Find("adcounter").GetComponent<adcount>().counter++;
        }
        
    }
    void Analyze()
    {

        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            Analytics.CustomEvent("Winner", new Dictionary<string, object>
        {
            {"Winner",  winner}
        });
        }
    }

	

}
