using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObject : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * 10));
    }
}
