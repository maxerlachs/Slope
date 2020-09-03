using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoScript1 : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Wight;

    public bool two;

    void Start()
    {
        two = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (two == true)
        {
            x.color = Wight;
        }
    }

    public void Two()
    {
        two = false;
        x.color = Green;
    }
}
