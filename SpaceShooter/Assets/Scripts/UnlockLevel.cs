using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockLevel : MonoBehaviour {

    public static int level;
    public int max_level;
    public GameObject[] levelUnlocked;

	// Use this for initialization
	void Start () {
        level = PlayerPrefs.GetInt("level", level);
		
	}
	
	// Update is called once per frame
	void Update () {
        for(int i=1; i<= max_level; i++)
        {
            if(i <= level)
            {
                levelUnlocked[i].SetActive(false);
                Debug.Log("" + level);
            }
            else
            {
                levelUnlocked[i].SetActive(true);
                Debug.Log("" + level);


            }
        }
		
	}

    public void Reset()
    {
        level = 1;
        PlayerPrefs.SetInt("level", level);

    }

        
 }
