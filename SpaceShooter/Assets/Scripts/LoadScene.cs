using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

   

    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadSetting()
    {
        SceneManager.LoadScene("SettingScene");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void LoadLevels()
    {
        SceneManager.LoadScene("LevelMenu");
    }

}
