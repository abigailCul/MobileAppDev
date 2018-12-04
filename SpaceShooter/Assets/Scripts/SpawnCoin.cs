using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour {
    public GameObject[]obj;

    [SerializeField]
    float SpawnMinRate = 1f;
    [SerializeField]
    float SpawnMaxRate = 4f;


    // Use this for initialization
    void Start() {
        SpawnStart();
      }

    void SpawnStart()
    {
        // instantiate object randomly - spawns coins randomly in the range
        Instantiate(obj[UnityEngine.Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("SpawnStart", UnityEngine.Random.Range(SpawnMinRate, SpawnMaxRate));

    }


}
