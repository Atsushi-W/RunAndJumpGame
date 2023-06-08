using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideController : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string name = collision.gameObject.tag;

        if (name == "Player")
        {
            collision.gameObject.SetActive(false);
            gameManager.GameOver();
        }
    }
}
