﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyControl : MonoBehaviour
{
    public Boundary boundary;

    [SerializeField]
    private float enemySpeed = 3f;
    public int enemyHealth;


    

    void Update()
    {
        //Get enemy current pos
        Vector2 position = transform.position;

        //Enemy new position
        position = new Vector2(position.x, position.y - enemySpeed * Time.deltaTime);

        //Enemy updated position
        transform.position = position;

        //bottom left screen
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));


        //IF enemy leaves the screen .. enemy destryo
        if (transform.position.y < min.y)
        {
            Destroy(gameObject);
        }

        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        //Detect collision of the enemy ship with the player ship, or with a players bullet
        if((col.tag == "PlayerShipTag"))
        {
            //Destroy enemy ship
            Destroy(gameObject);
          
        }

        if ((col.tag == "PlayerBulletTag"))
        {
            //Destroy enemy ship
            Destroy(col.gameObject);
           
        }
        //Checking if health is less than or greater to 0
        if (enemyHealth >= 0)
        {
            enemyHealth--;
        }
        if (enemyHealth <= 0)
        {
            Destroy(gameObject); //destroy enemy
        }
    }
}