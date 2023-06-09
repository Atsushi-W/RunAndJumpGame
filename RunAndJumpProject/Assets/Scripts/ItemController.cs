using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameManager gameManager;
    public int scorePoint = 100;

    private void Awake()
    {
        transform.position = new Vector2(transform.position.x, Random.Range(-gameManager.MaxHeight(), gameManager.MaxHeight()));
    }

    void Start()
    {
 
    }

    void Update()
    {
        if (transform.position.x < gameManager.EndPosition().x)
        {
            transform.position = gameManager.RandomTransormPosition();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string name = collision.gameObject.tag;

        if (name == "Player")
        {
            gameManager.AddScore(scorePoint);
            transform.position = gameManager.RandomTransormPosition();
        }
    }
}
