using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EaselSwap : MonoBehaviour
{
    public GameObject Timer;
    private Timer TimerScript;

    public bool IsFirstEasel;
    public bool IsSecondEasel;
    public bool IsThirdEasel;
    public bool IsFourthEasel;
    public bool IsFifthEasel;
    public bool IsSixthEasel;
    public bool IsSeventhEasel;
    public bool IsEighthEasel;

    public bool Showcase;

    public bool StartPainting;
    public bool DonePainting;

    private bool isTimerRunning;

    public int TimerElapses;

    Animator animator;

    //private IEnumerator PaintingCheck;

    void Start()
    {
        animator = GetComponent<Animator>();

        StartPainting = false;
        DonePainting = false;

        TimerElapses = 0;

        TimerScript = Timer.GetComponent<Timer>();
        isTimerRunning = TimerScript.timerIsRunning;
    }

    void Update()
    {
        animator.SetBool("StartPainting", StartPainting);
        animator.SetBool("DonePainting", DonePainting);

        isTimerRunning = TimerScript.timerIsRunning;

        if (isTimerRunning == false)
        {
            TimerElapses++;
            DonePainting = true;
            PaintingCheck();
        }

        if (IsFirstEasel == true && DonePainting != true)
        {
            StartPainting = true;
        }

        if (IsSecondEasel == true && TimerElapses == 1 && DonePainting != true)
        {
            StartPainting = true;

        }

        if (IsThirdEasel == true && TimerElapses == 2 && DonePainting != true)
        {
            StartPainting = true;
        }

        if (IsFourthEasel == true && TimerElapses == 3 && DonePainting != true)
        {
            StartPainting = true;
        }

        if (IsFifthEasel == true && TimerElapses == 4 && DonePainting != true)
        {
            StartPainting = true;
        }

        if (IsFifthEasel == true && TimerElapses == 5 && DonePainting != true)
        {
            StartPainting = true;
        }

        if (IsFifthEasel == true && TimerElapses == 6 && DonePainting != true)
        {
            StartPainting = true;
        }

        if (IsFifthEasel == true && TimerElapses == 7 && DonePainting != true) 
        {
            StartPainting = true;
        }

        if (TimerElapses == 8)
        {
            Showcase = true;
        }
    }

    private void TimeElapse()
    {
        DonePainting = true;
    }

    IEnumerator PaintingCheck()
    {
        Showcase = false;
        yield return null;
    }
}
