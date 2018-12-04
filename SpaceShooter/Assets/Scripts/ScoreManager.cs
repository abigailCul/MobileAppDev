using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    private int HighScore = 0;
    public Text ScoreT;
    // Use this for initialization
    void Awake () {
        // find the text
        ScoreT = GetComponent<Text>();
        // used to get the data for the high score
        HighScore = PlayerPrefs.GetInt("highScore");
        //score is 0 to start with
        score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        ScoreT.text = "Score: " + score;
        if(score>HighScore)
        {
            // the high score is now updated to your recieved score
            HighScore = score;
        }
        //the score text
        GameObject.Find("s").GetComponent<Text>().text = "Score: " + score;
        GameObject.Find("hs").GetComponent<Text>().text = "High Score: " + PlayerPrefs.GetInt("highScore");

    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("highScore", HighScore);
        PlayerPrefs.Save();
    }
}
