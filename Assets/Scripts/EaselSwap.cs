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

    [SerializeField] private bool isTimerRunning;

    [SerializeField] private bool StopElapse;

    public int TimerElapses;

    Animator animator;

    //private IEnumerator PaintingCheck;

    void Start()
    {
        animator = GetComponent<Animator>();

        StartPainting = false;
        DonePainting = false;

        TimerElapses = 0;

        StopElapse = false;

        TimerScript = Timer.GetComponent<Timer>();
        isTimerRunning = TimerScript.timerIsRunning;
    }

    void FixedUpdate()
    {
        animator.SetBool("StartPainting", StartPainting);
        animator.SetBool("DonePainting", DonePainting);
        animator.SetBool("Showcase", Showcase);

        animator.SetBool("IsFirstEasel", IsFirstEasel);
        animator.SetBool("IsSecondEasel", IsSecondEasel);
        animator.SetBool("IsThirdEasel", IsThirdEasel);
        animator.SetBool("IsFourthEasel", IsFourthEasel);
        animator.SetBool("IsFifthEasel", IsFifthEasel);
        animator.SetBool("IsSixthEasel", IsSixthEasel);
        animator.SetBool("IsSeventhEasel", IsSeventhEasel);
        animator.SetBool("IsEighthEasel", IsEighthEasel);


        isTimerRunning = TimerScript.timerIsRunning;


        if (isTimerRunning == false && StopElapse == false)
        {
            StartCoroutine(TimeElapse());
        }

        if (IsFirstEasel == true && DonePainting != true)
        {
            StartPainting = true;
        }

        if (IsSecondEasel == true && TimerElapses == 1 && DonePainting == true)
        {
            StartPainting = true;
            DonePainting = false;
        }

        if (IsThirdEasel == true && TimerElapses == 2 && DonePainting == true)
        {
            StartPainting = true;
            DonePainting = false;
        }

        if (IsFourthEasel == true && TimerElapses == 3 && DonePainting == true)
        {
            StartPainting = true;
            DonePainting = false;
        }

        if (IsFifthEasel == true && TimerElapses == 4 && DonePainting == true)
        {
            StartPainting = true;
            DonePainting = false;
        }

        if (IsSixthEasel == true && TimerElapses == 5 && DonePainting == true)
        {
            StartPainting = true;
            DonePainting = false;
        }

        if (IsSeventhEasel == true && TimerElapses == 6 && DonePainting == true)
        {
            StartPainting = true;
            DonePainting = false;
        }

        if (IsEighthEasel == true && TimerElapses == 7 && DonePainting == true) 
        {
            StartPainting = true;
            DonePainting = false;
        }

        if (TimerElapses >= 8)
        {
            Showcase = true;
        }

       
    }
    IEnumerator TimeElapse()
    {
        Showcase = false;
        StartPainting = false;
        DonePainting = true;
        TimerElapses++;
        StopElapse = true;

        yield return new WaitForSeconds(5);

        StopElapse = false;
    }
}
