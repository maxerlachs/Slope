using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeScript1 : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Wight;

    public bool three;

    void Start()
    {
        three = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (three == true)
        {
            x.color = Wight;
        }
    }

    public void Three()
    {
        three = false;
        x.color = Green;
    }
}
