using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SixScript1 : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Wight;

    public bool six;

    void Start()
    {
        six = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (six == true)
        {
            x.color = Wight;
        }

    }

    public void Six()
    {
        six = false;
        x.color = Green;
    }
}
