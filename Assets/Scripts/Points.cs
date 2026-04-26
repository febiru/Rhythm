using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{
    public TMP_Text PointText;
    public GameObject[] NotePrefabs;
    private int points = 0;
    private HashSet<GameObject> countedNotes = new HashSet<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        PointText.text = "Points: " + points;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject n in NotePrefabs)
        {
            NotePoint notePoint = n.GetComponent<NotePoint>();
            
            if(notePoint.counted && !countedNotes.Contains(n))
            {
                points += notePoint.noteSO.pointNote;
                PointText.text = "Points: " + points;
                countedNotes.Add(n);
            } else if(notePoint.WrongNote && !countedNotes.Contains(n))
            {
                points = 0;
                countedNotes.Clear();  // Clear all counted notes
                PointText.text = "Points: " + points;
            }
        }
    }
}
