using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    public GameObject[] notePrefab;
    public GameObject Indicator;
    public GameObject Trigger;
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
                n.transform.position = Vector3.MoveTowards(n.transform.position, Trigger.transform.position, beatTempo * Time.deltaTime);
            }
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
