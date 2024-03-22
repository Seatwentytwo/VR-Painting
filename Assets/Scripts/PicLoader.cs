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
    private int TimerElapsed;

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
            //Intro;
        }
    }
}
