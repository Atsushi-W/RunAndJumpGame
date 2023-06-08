using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb2D;
    private float jumpPower = 180.0f;
    private int jumpMaxCount = 2;
    public int jumpCount = 0;

    void Start()
    {
        playerRb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump") && jumpCount < jumpMaxCount)
        {
            playerRb2D.velocity = Vector2.zero;
            playerRb2D.AddForce(Vector2.up * jumpPower);
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string name = collision.gameObject.tag;
        if(name == "Block")
        {
            jumpCount = 0;
        }
    }
}
