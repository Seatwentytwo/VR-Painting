using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EaselSwap : MonoBehaviour
{
    public bool IsFirstEasel;
    public bool IsSecondEasel;
    public bool IsThirdEasel;
    public bool IsFourthEasel;
    public bool IsFifthEasel;

    public bool Showcase;

    private bool StartPainting;
    private bool DonePainting;

    public int TimerElapses;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        StartPainting = false;
        DonePainting = false;

        TimerElapses = 0;
    }

    void Update()
    {
        animator.SetBool("StartPainting", StartPainting);
        animator.SetBool("DonePainting", DonePainting);

        if (IsFirstEasel == true)
        {
            StartPainting = true;
        }

        if (IsSecondEasel == true && TimerElapses == 1)
        {
            StartPainting = true;
        }

        if (IsThirdEasel == true && TimerElapses == 2)
        {
            StartPainting = true;
        }

        if (IsFourthEasel == true && TimerElapses == 3)
        {
            StartPainting = true;
        }

        if (IsFifthEasel == true && TimerElapses == 4)
        {
            StartPainting = true;
        }

        if (TimerElapses == 5)
        {
            Showcase = true;
        }
    }
}
