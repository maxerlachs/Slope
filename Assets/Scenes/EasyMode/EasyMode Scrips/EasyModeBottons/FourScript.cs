using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourScript : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Redd;
    public Color Wight;

    public bool four;
    public bool touch;

    void Start()
    {
        four = true;
        touch = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (four == true)
        {
            x.color = Wight;
        }
        if (touch == false)
        {
            if (four == true)
            {
                x.color = Redd;
            }
        }
    }

    public void Four()
    {
        four = false;
        x.color = Green;
    }
}
