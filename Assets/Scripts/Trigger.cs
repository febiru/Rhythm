using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
                button.gameObject.SetActive(true);

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
