using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NineScript : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Red;
    public Color Wight;

    public bool nine;
    public bool touch;

    void Start()
    {
        nine = true;
        touch = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (nine == true)
        {
            x.color = Wight;
        }
        if (touch == false)
        {
            if (nine == true)
            {
                x.color = Red;
            }
        }
    }

    public void Nine()
    {
        nine = false;
        x.color = Green;
    }
}
