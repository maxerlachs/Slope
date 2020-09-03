using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneScript : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Red;
    public Color Wight;

    public bool one;
    public bool touch;

    void Start()
    {
        one = true;
        touch = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (one == true)
        {
            x.color = Wight;
        }
        if (touch == false)
        {
            x.color = Red;
        }
    }

    public void One()
    {
        one = false;
        x.color = Green;
    }
}
