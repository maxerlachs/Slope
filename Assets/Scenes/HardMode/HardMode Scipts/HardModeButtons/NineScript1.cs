using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NineScript1 : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Wight;

    public bool nine;

    void Start()
    {
        nine = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (nine == true)
        {
            x.color = Wight;
        }
    }

    public void Nine()
    {
        nine = false;
        x.color = Green;
    }
}
