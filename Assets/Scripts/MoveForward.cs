using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{   public float Forwardspeed;
    public float IncreaseinSpeed;
    void Update()

    {
        Forwardspeed += IncreaseinSpeed * Time.deltaTime;
        transform.Translate(Vector3.left *Forwardspeed  *Time.deltaTime); 
    }
}
