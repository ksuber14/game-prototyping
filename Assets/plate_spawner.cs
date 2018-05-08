using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plate_spawner : MonoBehaviour {
    public GameObject Plate;
    float randx;
    Vector2 wheretospawn;
    public float spawnrate = 2f;
    float nextspawn = 1.0f;
    private static object Random;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextspawn)
        { nextspawn = Time.time + spawnrate;
            float randx = (5.08f - 5.08f);
            wheretospawn = new Vector2(randx, transform.position.y);
            Instantiate(Plate, wheretospawn, Quaternion.identity);
	}
}
    
    
        
    }


