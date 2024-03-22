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

    public Material myMaterial;

    private EaselSwap ElapseScript;
    public int TimerElapsed;

    // Start is called before the first frame update
    void Start()
    {
        ElapseScript = ElapseEasel.GetComponent<EaselSwap>();
    }

    // Update is called once per frame
    void Update()
    {
        TimerElapsed = ElapseScript.TimerElapses;

        if (TimerElapsed == 0)
        {
            myMaterial.mainTexture = Intro;
        }

        if (TimerElapsed == 1)
        {
            myMaterial.mainTexture = Tree;
        }

        if (TimerElapsed == 2)
        {
            myMaterial.mainTexture = Eye;
        }

        if (TimerElapsed == 3)
        {
            myMaterial.mainTexture = Bell;
        }

        if (TimerElapsed == 4)
        {
            myMaterial.mainTexture = Pizza;
        }

        if (TimerElapsed == 5)
        {
            myMaterial.mainTexture = Easel;
        }

        if (TimerElapsed == 6)
        {
            myMaterial.mainTexture = Triangle;
        }

        if (TimerElapsed == 7)
        {
            myMaterial.mainTexture = Moon;
        }

        if (TimerElapsed == 8)
        {
            myMaterial.mainTexture = End;
        }
    }
}
