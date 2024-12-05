using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    public TextMeshProUGUI timeText;
    float time;
    public bool timerRunning;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        timerRunning = false;
    }

    void Update()
    {
        if (timerRunning)
        {
            time += Time.deltaTime;
            int hours = (int)(time / 3600);
            int minutes = (int)((time % 3600) / 60);
            int seconds = (int)(time % 60);
            timeText.text = $"{hours}:{minutes:00}:{seconds:00}";
        }
    }
}
