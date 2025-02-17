using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTriggerScript : MonoBehaviour
{
    private Text winText;

    void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");
        if (canvas != null)
        {
            winText = canvas.transform.Find("WinText").GetComponent<Text>();
            if (winText != null)
            {
                winText.gameObject.SetActive(false);
            }
            else
            {
                Debug.LogError("WinText component not found on Canvas!");
            }
        }
        else
        {
            Debug.LogError("Canvas object not found!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (winText != null)
            {
                winText.gameObject.SetActive(true);
            }
            else
            {
                Debug.LogError("winText is not assigned!");
            }
        }
    }
}

