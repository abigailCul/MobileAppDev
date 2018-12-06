using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2BulletScript : MonoBehaviour {


    public int score2Value; // score when enemy destroyed

    public Level2Score levelScore2;


    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {
        //  Invoke("Destroy", 2);
        levelScore2 = FindObjectOfType<Level2Score>();


    }

    void OnTriggerEnter2D(Collider2D col)
    {

        //Detect collision of the enemy ship with the player ship, or with a players bullet
        if (col.tag == "EnemyShipTag")
        {

            //Destroy enemy ship
            Destroy(gameObject);
            // add points when ship is his
            levelScore2.score += score2Value = 100;

        }
    }
}