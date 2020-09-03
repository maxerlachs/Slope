using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneScript1 : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Wight;

    public bool one;

    void Start()
    {
        one = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (one == true)
        {
            x.color = Wight;
        }
    }

    public void One()
    {
        one = false;
        x.color = Green;
    }

     
}
