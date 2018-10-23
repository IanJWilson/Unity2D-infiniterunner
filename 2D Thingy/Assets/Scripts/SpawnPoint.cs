using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public GameObject Fireball;

	// Use this for initialization
	void Start () {

        Instantiate(Fireball, transform.position, Quaternion.identity);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
