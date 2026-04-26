using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hollow : MonoBehaviour
{
    public GameObject[] NotePrefabs;
    public bool isPassed;
    // Start is called before the first frame update
    void Start()
    {
        isPassed = false;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        isPassed = true;
    }
    
    void Update()
    {
        foreach(GameObject n in NotePrefabs)
        {
            if(isPassed)
            {
                n.SetActive(false);
            }
        }
    }
}
