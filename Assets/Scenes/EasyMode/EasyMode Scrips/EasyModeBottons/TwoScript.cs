using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoScript : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Red;
    public Color Wight;

    public bool two;
    public bool touch;

    void Start()
    {
        two = true;
        touch = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (two == true)
        {
            x.color = Wight;
        }
        if (touch == false)
        {
                x.color = Red;
        }
    }

    public void Two()
    {
        two = false;
        x.color = Green;
    }
}
