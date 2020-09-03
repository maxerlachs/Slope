using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float zahl;

    public void Start()
    {

        zahl = -2.5f;
    }

    public void Update()
    {
        zahl = zahl - 0.01f;
        transform.Translate(Vector3.forward * zahl * Time.deltaTime);
    }
}