using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SixScript : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Red;
    public Color Wight;

    public bool six;
    public bool touch;

    void Start()
    {
        six = true;
        touch = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (six == true)
        {
            x.color = Wight;
        }

        if(touch == false)
        {
            if(six == true)
            {
                x.color = Red;
            }
        }
    }

    public void Six()
    {
        six = false;
        x.color = Green;
    }
}
