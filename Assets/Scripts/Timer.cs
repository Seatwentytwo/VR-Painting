using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject EaselSwapper;
    private EaselSwap EaseScript;

    AudioSource Ticking;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    bool StartPainting;

    private void Start()
    {
        Ticking = GetComponent<AudioSource>();
        timerIsRunning = true;

        EaseScript = GetComponent<EaselSwap>();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0 && timerIsRunning == true)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timerIsRunning = false;
            }
        }

        if (timerIsRunning == false)
        {
            timeRemaining = 60;
        }

        if (StartPainting == true)
        {
            timeRemaining = 60;
            timerIsRunning = true;
        }
    }
}
