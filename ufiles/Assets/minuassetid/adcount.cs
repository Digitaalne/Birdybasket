using UnityEngine;
using System.Collections;

public class adcount : MonoBehaviour {
	public int counter = 0;
    public static adcount Instance;
    void Awake() {

		DontDestroyOnLoad(transform.gameObject);

        if (Instance)
        {

            DestroyImmediate(gameObject);

        }
        else
        {

            DontDestroyOnLoad(gameObject);
            Instance = this;

        }
    }

}
