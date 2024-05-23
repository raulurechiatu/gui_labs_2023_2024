using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManagement : MonoBehaviour
{
    TextMeshProUGUI timeText;
    int contor = 0;
    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        // timeText = transform.Find("TimeText").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        timeText.text = "" + contor;
        contor++;
    }
}
