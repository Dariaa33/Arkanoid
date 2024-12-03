using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;
    float time;
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;
        int hours = (int)(time / 3600);
        int minutes = (int)((time % 3600) / 60);
        int seconds = (int)(time % 60);
        int miliseconds = (int)((time * 100) % 100);
        timeText.text = $"{hours}:{minutes:00}:{seconds:00}:{miliseconds:00}";
    }
}
