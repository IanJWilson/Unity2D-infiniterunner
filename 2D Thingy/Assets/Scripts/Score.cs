using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private float timer;
    public int score;
    public Text scoreDisplay;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if (timer > 5f)
        {
            score += 5;

            timer = 0;

        }
        scoreDisplay.text = score.ToString();
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Destroy(other.gameObject);
        Debug.Log(score);
    }
}
