using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tips : MonoBehaviour {
    public string[] tricks = new string[5];
    int random;
    Text text;
	// Use this for initialization
	void Start () {
        tricks[0] = "In Duobirds one of your birds stays same location as same as before scoring";
        tricks[1] = "If you can time your jump on hoop, you can get a boost";
        tricks[2] = "If enough force is used, you can fly through hoop";
        tricks[3] = "You can slow down enemy, if you jump on him";
        tricks[4] = "Ball rotation saves after scoring, use it for your own advantage";
        random = Random.Range(0, tricks.Length);
        GameObject.Find("tips").GetComponent<Text>().text = "Tip: "+ tricks[random];
        
	}
	
}
