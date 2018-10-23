using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testspawn : MonoBehaviour {

    public GameObject[] FireballPatterns;

    private float timeBTWSpawns;
    public float starttimeBTWSpawns;
    public float decreaseTime;
    public float minTime = 0.65f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (timeBTWSpawns <= 0)
        {

            int rand = Random.Range(0, FireballPatterns.Length);
            Instantiate(FireballPatterns[rand], transform.position, Quaternion.identity);
            timeBTWSpawns = starttimeBTWSpawns;
            if (starttimeBTWSpawns > minTime)
            {
                starttimeBTWSpawns -= decreaseTime;
            }
            
        }

        else
        {
            timeBTWSpawns -= Time.deltaTime;
        }
		
	}
}
