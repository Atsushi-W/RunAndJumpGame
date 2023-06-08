using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score;
    private float span = 1.0f;
    private int TimeScore = 10;

    void Start()
    {
        score = 0;
        scoreText.text = "SCORE: " + score;
        StartCoroutine(AddScoreTime());
    }

    void Update()
    {
        
    }

    IEnumerator AddScoreTime()
    {
        while(true)
        {
            yield return new WaitForSeconds(span);
            AddScore(TimeScore);
        }
    }


    private void AddScore(int scorePoint)
    {
        score += scorePoint;
        scoreText.text = "SCORE: " + score;
    }
}
