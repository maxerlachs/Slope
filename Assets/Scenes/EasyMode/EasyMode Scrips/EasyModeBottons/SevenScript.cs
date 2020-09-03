using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SevenScript : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Red;
    public Color Wight;

    public bool seven;
    public bool touch;


    void Start()
    {
        seven = true;
        touch = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (seven == true)
        {
            x.color = Wight;
        }
        if (touch == false)
        {
            if (seven == true)
            {
                x.color = Red;
            }
        }
    }

    public void Seven()
    {
        seven = false;
        x.color = Green;
    }
}
