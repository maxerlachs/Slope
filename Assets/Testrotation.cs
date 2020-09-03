using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testrotation : MonoBehaviour
{  
    void Update()
    {
        transform.Rotate(new Vector3(0, 100, 0)* Time.deltaTime);
    }
}
