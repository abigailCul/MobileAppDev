﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    [SerializeField]
    private float enemySpeed = 2f;

    void Start()
    {

    }

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
        if(transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
    }
}