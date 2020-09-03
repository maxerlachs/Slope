using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EightScript : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Red;
    public Color Wight;

    public bool eight;
    public bool touch;

    void Start()
    {
        eight = true;
        touch = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (eight == true)
        {
            x.color = Wight;
        }
        if (touch == false)
        {
            if (eight == true)
            {
                x.color = Red;
            }
        }
    }

    public void Eight()
    {
        eight = false;
        x.color = Green;
    }
}
