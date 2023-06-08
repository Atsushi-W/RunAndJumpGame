using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatPlatform : MonoBehaviour
{
    public GameManager gameManager;
    public bool firstPlatform;

    void Start()
    {
        if (!firstPlatform)
        {
            transform.position = gameManager.RandomTransormPosition();
        }
    }

    void Update()
    {
        if(transform.position.x < gameManager.EndPosition().x)
        {
            transform.position = gameManager.RandomTransormPosition();
        }
    }
}
