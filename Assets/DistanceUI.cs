using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DistanceUI : MonoBehaviour
{
    TMP_Text counterText;
    int counter = 0;
    void Start()
    {
        counterText = GameObject.Find("CounterText").GetComponent<TMP_Text>();
        counter = PlayerPrefs.GetInt("Counter");
    }

    void Update()
    {
        counterText.text = "" + counter;
        counter++;
        PlayerPrefs.SetInt("Counter", counter);
    }
}
