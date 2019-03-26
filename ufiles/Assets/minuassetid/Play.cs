using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;
using System.Collections.Generic;
using System.Collections;

public class Play : MonoBehaviour {

public void load()
	{
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        Analytics.CustomEvent("GameChosen", new Dictionary<string, object>
        {
            {"GameMode", "MonoBird" }
        });
    }
}