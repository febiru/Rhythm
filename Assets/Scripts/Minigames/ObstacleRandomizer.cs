using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObstacleRandomizer : MonoBehaviour
{
    public static ObstacleRandomizer Instance;

    public GameObject[] obstacles;
    public float speed = 5f;
    public float startY = 5f;
    public float offscreenY = -5f;

    private int currentIndex = 0;
    public TMP_Text scoreText;
    private int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        currentIndex = 0;
        UpdateScoreText();
        ActivateCurrentObstacle();
    }

    void Update()
    {
        if (obstacles == null || obstacles.Length == 0)
            return;

        GameObject currentObstacle = obstacles[currentIndex];
        if (currentObstacle == null)
            return;

        currentObstacle.transform.position += Vector3.down * speed * Time.deltaTime;

        if (currentObstacle.transform.position.y <= offscreenY)
        {
            score++;
            UpdateScoreText();

            currentObstacle.SetActive(false);
            currentIndex = (currentIndex + 1) % obstacles.Length;
            ActivateCurrentObstacle();
        }
    }

    public void HitObstacle(GameObject obstacleObject)
    {
        if (obstacleObject != obstacles[currentIndex])
            return;

        score--;
        UpdateScoreText();

        obstacleObject.SetActive(false);
        currentIndex = (currentIndex + 1) % obstacles.Length;
        ActivateCurrentObstacle();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    private void ActivateCurrentObstacle()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            if (obstacles[i] != null)
                obstacles[i].SetActive(i == currentIndex);
        }

        ResetPosition();
    }

    private void ResetPosition()
    {
        if (obstacles == null || obstacles.Length == 0)
            return;
        
        GameObject currentObstacle = obstacles[currentIndex];
        if (currentObstacle == null)
            return;

        currentObstacle.transform.position = new Vector3(Random.Range(-5f, 5f), startY, 0);
    }
}
