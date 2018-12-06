﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    

    public int scoreValue; // score when enemy destroyed
    public int score2Value; // score when enemy destroyed

    public ScoreManager scoreManager;


    void Start()
    {
        

    }
    // Update is called once per frame
    void Update () {
        //  Invoke("Destroy", 2);
        scoreManager = FindObjectOfType<ScoreManager>();

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        //Detect collision of the enemy ship with the player ship, or with a players bullet
        if (col.tag == "EnemyShipTag")
        {
         
            //Destroy enemy ship
            Destroy(gameObject);
            // add points when ship is his
            scoreManager.score += scoreValue = 100;


        }
    }
}
