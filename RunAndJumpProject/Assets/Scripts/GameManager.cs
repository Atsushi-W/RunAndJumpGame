using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject start;
    public GameObject end;
    private Vector2 startPos;
    private Vector2 endPos;
    private float maxHeight = 0.7f;

    void Start()
    {
        startPos = start.transform.position;
        endPos = end.transform.position;
    }

    void Update()
    {
        
    }

    public Vector2 StartPosition()
    {
        return startPos;
    }

    public Vector2 EndPosition()
    {
        return endPos;
    }

    public float MaxHeight()
    {
        return maxHeight;
    }

    public Vector2 RandomTransormPosition()
    {
        return new Vector2(startPos.x, Random.Range(-maxHeight, maxHeight) );
    }
}
