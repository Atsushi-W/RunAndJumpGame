using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PressStart : MonoBehaviour
{
    public float speed;
    private Text startText;
    private float time;

    private void Awake()
    {
        startText = GetComponent<Text>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) OnPressSpace();

        startText.color = ChangeColorAlpha(startText.color);
    }

    private Color ChangeColorAlpha(Color color)
    {
        time += Time.deltaTime;
        color.a = Mathf.Abs(Mathf.Sin(time)) * speed;
        return color;
    }

    private void OnPressSpace()
    {
        SceneManager.LoadScene("Main");
    }
}
