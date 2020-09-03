using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiveScript : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Red;
    public Color Wight;

    public bool five;
    public bool touch;

    void Start()
    {
        five = true;
        touch = true;
        x.color = Wight;

    }
    private void Update()
    {
        if (five == true)
        {
            x.color = Wight;
        }
        if (touch == false)
        {
            if (five == true)
            {
                x.color = Red;
            }
        }
    }

    public void Five()
    {
     five = false;
        x.color = Green;
    }
             

}
