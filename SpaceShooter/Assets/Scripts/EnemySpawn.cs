using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public Boundary boundary;

    public GameObject Enemy;

    [SerializeField]
    float maxSpawnRateInSeconds = 4f;

    // Use this for initialization
    void Start () {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

        // increase spawn rate every 40 seconds
        InvokeRepeating("IncreaseSpawnRate", 0f, 40f);
        
	}
	
	// Update is called once per frame
	void Update () {
       
		
	}

    void SpawnEnemy()
    {

    // the bottom left of the screen
   Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

   //top right point of screen
   Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

   // create enemy
   GameObject anEnemy = (GameObject)Instantiate(Enemy);
   //anEnemy.transform.position = new Vector2(UnityEngine.Random.Range(min.x, max.x), max.y);
  

    //Schedule next enemy
    ScheduleNextEnemySpawn();
    }

    private void ScheduleNextEnemySpawn()
    {
        float spawnSeconds;

        if (maxSpawnRateInSeconds > 1f)
        {
            spawnSeconds = UnityEngine.Random.Range(1f, maxSpawnRateInSeconds);
        }
        else
            spawnSeconds = 1f;
        Invoke("SpawnEnemy", spawnSeconds);
    }

    // Increase difficulty
    void IncreaseSpawnRate()
    {
        if (maxSpawnRateInSeconds > 1f)
            maxSpawnRateInSeconds--;

        if (maxSpawnRateInSeconds == 1f)
            CancelInvoke("IncreaseSpawnRate");
    }
}
