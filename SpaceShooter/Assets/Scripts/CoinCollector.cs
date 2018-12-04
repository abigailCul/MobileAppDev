using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour {

    //your number of coins
    public int coin = 0;
    // The coin text on game screen
    public Text coinCount;

    // Use this for initialization
    void Start () {
   
        // find the text
        coin = PlayerPrefs.GetInt("coin", 0);
	}
	
	// Update is called once per frame
	void Update () {
        // updating the coin text as number of coins increases
         coinCount.text = coin.ToString(); 

    }
    void UpdateCoins()
    {
        // updating the coin text as number of coins increases
        coinCount.text = coin.ToString();

    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if ((col.tag == "Coin"))
        {
            // increment num of coins
            coin++;
            coinCount.text = coin.ToString();
            Destroy(col.gameObject);
        }
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("coin", coin);
        PlayerPrefs.Save();
    }
}
