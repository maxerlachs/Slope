using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHard : MonoBehaviour
{
    public float zahl;

    public void Start()
    {

        zahl = -5;
    }

    public void Update()
    {
        zahl = zahl - 0.01f;
        transform.Translate(Vector3.forward * zahl * Time.deltaTime);
    }
}