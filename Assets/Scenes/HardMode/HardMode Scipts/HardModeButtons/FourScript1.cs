using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourScript1 : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Wight;

    public bool four;

    void Start()
    {
        four = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (four == true)
        {
            x.color = Wight;
        }
    }

    public void Four()
    {
        four = false;
        x.color = Green;
    }
}
