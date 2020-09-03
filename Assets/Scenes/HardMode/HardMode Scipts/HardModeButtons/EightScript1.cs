using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EightScript1 : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Wight;

    public bool eight;

    void Start()
    {
        eight = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (eight == true)
        {
            x.color = Wight;
        }
    }

    public void Eight()
    {
        eight = false;
        x.color = Green;
    }
}
