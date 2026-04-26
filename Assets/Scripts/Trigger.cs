using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public Button button; 
    public GameObject Indicator;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (button != null)
            {
                //button.gameObject.SetActive(true);
                SceneManager.LoadScene("Rhythm1");
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (button != null)
            {
                button.gameObject.SetActive(false);
                Indicator.SetActive(false);
            }
        }
    }
}
