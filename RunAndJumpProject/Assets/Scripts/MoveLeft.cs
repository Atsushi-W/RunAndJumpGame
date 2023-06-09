using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    public GameManager gameManager;

    void Start()
    {

    }

    void Update()
    {
        if(gameManager)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed * (gameManager.MoveSpeed()));
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed );
        }

    }
}
