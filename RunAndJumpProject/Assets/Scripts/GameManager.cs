using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject start;
    public GameObject end;
    public Text speedText;
    public Text timeText;
    public Text scoreText;
    public GameObject gameover;
    public GameObject mainCamera;
    public AudioSource gameoverVoice;

    private Vector2 startPos;
    private Vector2 endPos;
    private float maxHeight = 0.7f;
    private float speed;
    private float addSpeed = 0.5f;
    private float speedDisplay;
    private float span = 10.0f;
    private int time;
    private int score;
    private int TimeScore = 10;
    private bool isGameOver;

    void Start()
    {
        startPos = start.transform.position;
        endPos = end.transform.position;
        speed = 1;
        speedDisplay = 1;
        speedText.text = "SPEED: " + speedDisplay;
        time = 0;
        timeText.text = "TIME: " + time;
        score = 0;
        scoreText.text = "SCORE: " + score;
        StartCoroutine(AddMoveSpeed());
        StartCoroutine(CountUp());
    }

    void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene("Main");
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

    public float MoveSpeed()
    {
        return speed;
    }

    IEnumerator AddMoveSpeed()
    {
        while (true)
        {
            yield return new WaitForSeconds(span);
            speed += addSpeed;
            speedDisplay++;
            speedText.text = "SPEED: " + speedDisplay;
        }
    }

    IEnumerator CountUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            time++;
            timeText.text = "TIME: " + time;
            AddScore(TimeScore);
        }
    }
    public void AddScore(int scorePoint)
    {
        score += scorePoint;
        scoreText.text = "SCORE: " + score;
    }

    public void GameOver()
    {
        gameoverVoice.Play();
        speed = 0;
        StopAllCoroutines();
        ShakeCamera();
        gameover.SetActive(true);
        isGameOver = true;
    }

    private void ShakeCamera()
    {
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        Vector3 mainCameraPos = mainCamera.transform.position;

        float count = 0f;
        float maxseconds = 0.5f;
        float maxShakeX = 0.125f;
        float maxShakeY = 0.125f;

        while (count < maxseconds)
        {
            float vx = mainCameraPos.x + Random.Range(-maxShakeX, maxShakeX);
            float vy = mainCameraPos.y + Random.Range(-maxShakeY, maxShakeY);

            mainCamera.transform.position = new Vector3(vx, vy, mainCameraPos.z);

            count += Time.deltaTime;

            yield return null;
        }

        mainCamera.transform.position = mainCameraPos;
    }
}
