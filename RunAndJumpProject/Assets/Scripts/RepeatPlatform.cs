using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatPlatform : MonoBehaviour
{
    public GameObject start;
    public GameObject end;
    private Vector2 startPos;
    private Vector2 endPos;
    private float maxHeight = 0.7f;

    public bool firstPlatform;

    void Start()
    {
        startPos = start.transform.position;
        endPos = end.transform.position;

        if (!firstPlatform)
        {
            transform.position = new Vector2(transform.position.x, Random.Range(-maxHeight, maxHeight));
        }
    }

    void Update()
    {
        if(transform.position.x < endPos.x)
        {
            transform.position = new Vector2(startPos.x,Random.Range(-maxHeight, maxHeight));
        }
    }
}
