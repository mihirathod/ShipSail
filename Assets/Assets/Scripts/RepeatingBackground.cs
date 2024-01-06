using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    public Vector3 StrtPos;
     [SerializeField] private float positionfoZ;

    void Start()
    {
    }

    void Update()
    {// isko change karo

        if (transform.position.z < positionfoZ)
        {
            transform.position = StrtPos;
        }
    }
}
