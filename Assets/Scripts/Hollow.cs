using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hollow : MonoBehaviour
{
    public GameObject[] NotePrefabs;
    public bool isPassed = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is a note (compare by tag or name instead of reference)
        if(other.CompareTag("Note") || other.gameObject.name.Contains("Note"))
        {
            isPassed = true;
            other.gameObject.SetActive(false); // Only deactivate the note that entered
        }
    }
}
