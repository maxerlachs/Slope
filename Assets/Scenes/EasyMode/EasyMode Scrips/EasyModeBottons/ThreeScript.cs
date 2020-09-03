using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeScript : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Red;
    public Color Wight;

    public bool three;
    public bool touch;

    void Start()
    {
        three = true;
        touch = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (three == true)
        {
            x.color = Wight;
        }
        if (touch == false)
        {
            if (three == true)
            {
                x.color = Red;
            }
        }
    }

    public void Three()
    {
        three = false;
        x.color = Green;
    }
}
