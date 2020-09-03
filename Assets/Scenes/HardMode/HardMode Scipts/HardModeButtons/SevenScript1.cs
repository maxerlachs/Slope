using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SevenScript1 : MonoBehaviour
{
    public Image x;
    public Color Green;
    public Color Wight;

    public bool seven;

    void Start()
    {
        seven = true;
        x.color = Wight;
    }
    private void Update()
    {
        if (seven == true)
        {
            x.color = Wight;
        }
    }

    public void Seven()
    {
        seven = false;
        x.color = Green;
    }
}
