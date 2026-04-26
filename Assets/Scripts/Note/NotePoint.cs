using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePoint : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public NoteSO noteSO;
    public bool counted;
    public bool WrongNote;
    // Start is called before the first frame update
    void Start()
    {
        WrongNote = false;
        canBePressed = false;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        canBePressed = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        WrongNote = true;
        canBePressed = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(keyToPress) && canBePressed)
        {
            counted = true;
            gameObject.SetActive(false);
        } 
    }
}
