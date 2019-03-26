using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class quit : MonoBehaviour {

	public void load()
	{
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
	}
}
