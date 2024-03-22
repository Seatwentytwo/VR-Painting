using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicLoader : MonoBehaviour
{
    public Texture2D Intro;
    public Texture2D Tree;
    public Texture2D Eye;
    public Texture2D Bell;
    public Texture2D Pizza;
    public Texture2D Easel;
    public Texture2D Triangle;
    public Texture2D Moon;
    public Texture2D End;

    public GameObject ElapseEasel;

    private EaselSwap ElapseScript;
    public int TimerElapsed;

    // Start is called before the first frame update
    void Start()
    {
        ElapseScript = GetComponent<EaselSwap>();
    }

    // Update is called once per frame
    void Update()
    {
        TimerElapsed = ElapseScript.TimerElapses;

        if (TimerElapsed == 0)
        {
            Intro.Apply();
        }

        if (TimerElapsed == 1)
        {
            Tree.Apply();
        }

        if (TimerElapsed == 2)
        {
            Eye.Apply();
        }

        if (TimerElapsed == 3)
        {
            Bell.Apply();
        }

        if (TimerElapsed == 4)
        {
            Pizza.Apply();
        }

        if (TimerElapsed == 5)
        {
            Easel.Apply();
        }

        if (TimerElapsed == 6)
        {
            Triangle.Apply();
        }

        if (TimerElapsed == 7)
        {
            Moon.Apply();
        }

        if (TimerElapsed == 8)
        {
            End.Apply();
        }
    }
}
