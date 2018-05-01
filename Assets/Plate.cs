using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour {

    public Color ColorToChangeTo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnParticleCollision(GameObject other)
    {
        GetComponent<SpriteRenderer>().color = ColorToChangeTo;

    }
}
