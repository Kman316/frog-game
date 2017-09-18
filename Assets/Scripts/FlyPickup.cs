﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPickup : MonoBehaviour {

    [SerializeField]
    private GameObject pickupPrefab;

	void OnTriggerEnter(Collider other)
    {

        // If the Collider other is tagged with "Player"... 
        if(other.CompareTag("Player"))
        {
			//..Add the pickup particles...
			Instantiate(pickupPrefab, transform.position, Quaternion.identity);

            //..decrement the total number of flies..
            FlySpawner.totalFlies--;

            //..Update the score..
            ScoreCounter.score++;

            Destroy(gameObject);
        }

    }


}