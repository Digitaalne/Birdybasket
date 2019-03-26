using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class mtt : MonoBehaviour {

	// Use this for initialization
	public void playmtt()
	{
        SceneManager.LoadScene(2);
        Analytics.CustomEvent("GameChosen", new Dictionary<string, object>
        {
            {"GameMode", "DuoBird" }
        });
    }
}
