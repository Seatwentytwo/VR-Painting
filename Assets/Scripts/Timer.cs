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

    void FixedUpdate()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0 /*&& timerIsRunning == true*/)
            {
                timeRemaining -= Time.deltaTime;
                timerIsRunning = true;
            }
            else
            {
                Debug.Log("Time has run out!");
                timerIsRunning = false;
                StartCoroutine(Cycle());
            }
        }
    }

    IEnumerator Cycle()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Restarting Cyle");
        timeRemaining = 90;
        timerIsRunning = true;
    }
}
