using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingShips : MonoBehaviour
{
    public float Rotatespeed;
    void Update()
    {
        transform.Rotate(0, Rotatespeed, 0);
    }
}
