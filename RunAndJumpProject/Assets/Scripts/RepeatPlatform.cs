using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatPlatform : MonoBehaviour
{
    public GameManager gameManager;
    public bool firstPlatform;

    private void Awake()
    {
        if (!firstPlatform)
        {
            transform.position = new Vector2(transform.position.x, Random.Range(-gameManager.MaxHeight(), gameManager.MaxHeight()));
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.x < gameManager.EndPosition().x)
        {
            transform.position = gameManager.RandomTransormPosition();
        }
    }
}
