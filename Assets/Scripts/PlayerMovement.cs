using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public float Speed;
    public float HorInput;
    public float posZ;
    void Update()
    {
        MOving();
        Bounds();
    }
    public void MOving()
    {
            HorInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * HorInput * Speed * Time.deltaTime);
    }
    public void Bounds()
    {
        if (transform.position.z > posZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,posZ);
        }
        else if (transform.position.z < -posZ)
        {
        }
    }
}
