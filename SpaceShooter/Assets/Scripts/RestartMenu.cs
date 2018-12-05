using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadGameRestart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadSettings()
    {
        Debug.Log("Loading settings...");
    }
}
