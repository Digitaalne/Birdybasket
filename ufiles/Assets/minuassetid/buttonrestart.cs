using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class buttonrestart : MonoBehaviour {

	// Use this for initialization
	public void restart ()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
	}
}
