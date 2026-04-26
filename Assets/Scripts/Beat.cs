using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Beat : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    public GameObject[] notePrefab;
    public GameObject Indicator;
    public GameObject Trigger;
    private bool sceneLoaded = false;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
           
      foreach (GameObject n in notePrefab)
        {
            if (hasStarted)
            {
                n.transform.position += new Vector3(beatTempo * Time.deltaTime, 0, 0);
            }
        }

        if (!sceneLoaded && allObjectAreDestroyed())
        {
            sceneLoaded = true;
            SceneManager.LoadScene("MainScene");
        }
    }
    

    bool allObjectAreDestroyed()
    {
        foreach(GameObject n in notePrefab)
        {
            if(n.activeInHierarchy)
            {
                return false;
            }
        }
        return true;
    }
}
