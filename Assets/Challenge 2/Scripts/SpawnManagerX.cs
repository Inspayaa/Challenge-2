﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float varyTimeSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        varyTimeSpawn = Random.Range(3.0f, 5.0f);

        InvokeRepeating("SpawnRandomBall", startDelay, varyTimeSpawn);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int spawnIndex = Random.Range( 0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[spawnIndex], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
