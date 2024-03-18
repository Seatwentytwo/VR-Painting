using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tip_Color : MonoBehaviour
{
    //Material[Blue, Red, Green, Cyan, Pink, Orange, Thinner] Colours;

    /*
    public Material Blue;
    public Material Red;
    public Material Green;
    public Material Cyan;
    public Material Pink;
    public Material Yellow;
    public Material Orange;
    public Material Thinner;
    */

    Material currentColour;

    Color32 orange = new Color32(255, 128, 0, 255);
    Color32 thinner = new Color32(255, 255, 255, 0);
    Color32 black = new Color32(0, 0, 0, 0);

    private void Start()
    {
        currentColour = GetComponent<Renderer>().material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            currentColour.color = Color.red;
        }

        else if (collision.gameObject.tag == "Black")
        {
            currentColour.color = black;
        }

        else if (collision.gameObject.tag == "Green")
        {
            currentColour.color = Color.green;
        }

        else if (collision.gameObject.tag == "Yellow")
        {
            currentColour.color = Color.yellow;
        }

        else if (collision.gameObject.tag == "Blue")
        {
            currentColour.color = Color.cyan;
        }

        else if (collision.gameObject.tag == "Pink")
        {
            currentColour.color = Color.magenta;
        }

        else if (collision.gameObject.tag == "Orange")
        {
            currentColour.color = orange;
        }

        else if (collision.gameObject.tag == "Thinner")
        {
            currentColour.color = thinner;
            thinner.a = 0;
        }
    }
}
