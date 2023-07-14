using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float DestroyBound;
    void Update()
    {
        DestroyOutOFBounds();
    }
    public void DestroyOutOFBounds()
    {
        if (transform.position.x < DestroyBound)
        {
            Destroy(gameObject);
        }
    }
}
