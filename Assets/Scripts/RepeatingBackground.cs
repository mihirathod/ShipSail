using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    public Vector3 StrtPos;
    void Start()
    {
        StrtPos = transform.position;
    }

    void Update()
    {// isko change karo

        if (transform.position.x < 157)
        {
            transform.position = StrtPos;
        }
    }
}
