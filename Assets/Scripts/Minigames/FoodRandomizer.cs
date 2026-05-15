using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRandomizer : MonoBehaviour
{
    public bool isTriggered = false;

    void Start()
    {
        ResetPosition();
    }

    void Update()
    {
        transform.position += new Vector3(0, -5f * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = true;
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        transform.position = new Vector3(Random.Range(-5f, 5f), 5f, 0);
    }
}
