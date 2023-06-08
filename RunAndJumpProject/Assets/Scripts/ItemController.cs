using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameManager gameManager;
    public ScoreManager scoreManager;
    public int scorePoint = 100;

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
            scoreManager.AddScore(scorePoint);
            transform.position = gameManager.RandomTransormPosition();
        }
    }
}
