using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public int damage;
    public float speed;
    public GameObject effect;

    public Fireball(int damage, float speed, GameObject effect)
    {
        this.damage = damage;
        this.speed = speed;
        this.effect = effect;
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().health--;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
}