using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodRandomizer : MonoBehaviour
{
    public static FoodRandomizer Instance;

    public GameObject[] food;
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
        ActivateCurrentFood();
    }

    void Update()
    {
        if (food == null || food.Length == 0)
            return;

        GameObject currentFood = food[currentIndex];
        if (currentFood == null)
            return;

        currentFood.transform.position += Vector3.down * speed * Time.deltaTime;

        if (currentFood.transform.position.y <= offscreenY)
        {
            score--;
            UpdateScoreText();

            currentFood.SetActive(false);
            currentIndex = (currentIndex + 1) % food.Length;
            ActivateCurrentFood();
        }
    }

    public void CollectFood(GameObject foodObject)
    {
        if (foodObject != food[currentIndex])
            return;

        score++;
        UpdateScoreText();

        foodObject.SetActive(false);
        currentIndex = (currentIndex + 1) % food.Length;
        ActivateCurrentFood();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    private void ActivateCurrentFood()
    {
        for (int i = 0; i < food.Length; i++)
        {
            if (food[i] != null)
                food[i].SetActive(i == currentIndex);
        }

        ResetPosition();
    }

    private void ResetPosition()
    {
        if (food == null || food.Length == 0)
            return;

        GameObject currentFood = food[currentIndex];
        if (currentFood == null)
            return;

        currentFood.transform.position = new Vector3(Random.Range(-5f, 5f), startY, 0);
    }
}
