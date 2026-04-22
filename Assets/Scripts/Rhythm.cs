using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhythm : MonoBehaviour
{
    public KeyCode keyToPress;
    private SpriteRenderer theSR;
    public SpriteRenderer defaultSprite;
    public GameObject hitSprite;
    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            Debug.Log("Key Pressed");
            hitSprite.SetActive(true);
        }
        if(Input.GetKeyUp(keyToPress))
        {
            hitSprite.SetActive(false);
        }
    }
}
