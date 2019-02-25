using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    int TimerSec = 00, TimerHod = 00, TimerMin = 00;
    float t;
    int hours;
    int minutes;
    int seconds;


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
        t = Time.time - startTime;
        hours = (((int)t / 60) / 24) + TimerHod;
        minutes = ((int)t / 60) + TimerMin;
        seconds = ((int)t % 60) + TimerSec;
    }

    void Start ()
    {
        t = Time.time - startTime;
        hours = (((int)t / 60) / 24);
        minutes = ((int)t / 60);
        seconds = ((int)t % 60);
    }

    void Update ()
    {
        t = Time.time - startTime;
        hours = (((int)t/60)/24)+TimerHod;
        minutes = ((int)t/60)+TimerMin;
        seconds = ((int)t %60)+TimerSec;
        timerText.text = hours + ":" + minutes + ":" + seconds;
    }
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    int TimerSec = 00, TimerHod = 00, TimerMin = 00;


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
*/