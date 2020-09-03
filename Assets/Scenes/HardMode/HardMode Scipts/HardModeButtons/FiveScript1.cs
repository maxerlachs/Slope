using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiveScript1 : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Wight;

    public bool five;

    void Start()
    {
        five = true;
        x.color = Wight;

    }
    private void Update()
    {
        if (five == true)
        {
            x.color = Wight;
        }
    }

    public void Five()
    {
     five = false;
        x.color = Green;
    }
             

}
