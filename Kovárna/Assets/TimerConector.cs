using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimerConector : MonoBehaviour
{
    public Text timerText;
    int TimerSec = 00, TimerHod = 00, TimerMin = 00;

    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;

        int hours = ((int)t/60)/24;
        int minutes = (int)t / 60;
        int seconds = (int)t % 60;
        hours = TimerHod;
        minutes = TimerMin;
        seconds = TimerSec;

        timerText.text = hours + ":" + minutes + ":" + seconds;
    }

    public void ResetBTN()
    {
        TimerHod = 00;
        TimerMin = 00;
        TimerSec = 00;
        timerText.text = TimerHod + ":" + TimerMin + ":" + TimerSec;
    }
    public void secBTN()
    {
        TimerSec = 30 + TimerSec;
        if (TimerSec >= 60)
        {
            TimerSec = TimerSec - 60;
            TimerMin = TimerMin + 1;
            timerText.text = TimerHod + ":" + TimerMin + ":" + TimerSec;
        }
        timerText.text = TimerHod + ":" + TimerMin + ":" + TimerSec;
    }
    public void minBTN()
    {
        TimerMin = 5 + TimerMin;
        if (TimerMin >= 60)
        {
            TimerMin = TimerMin - 60;
            TimerHod = TimerHod + 1;
            timerText.text = TimerHod + ":" + TimerMin + ":" + TimerSec;
        }
        timerText.text = TimerHod + ":" + TimerMin + ":" + TimerSec;
    }
    public void hodBTN()
    {
        TimerHod = 1 + TimerHod;
        timerText.text = TimerHod + ":" + TimerMin + ":" + TimerSec;
    }
    public void startBTN()
    {
        timerText.text = TimerHod + ":" + TimerMin + ":" + TimerSec;
    }
}