using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class single : MonoBehaviour {

	// Use this for initialization
	public void load()
	{
        SceneManager.LoadScene(3);
        Analytics.CustomEvent("GameChosen", new Dictionary<string, object>
        {
            {"GameMode", "AI" }
        });
    }
}
