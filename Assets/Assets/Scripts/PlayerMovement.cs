using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public float Speed;
    public float HorInput;
    public float posX;
    

    
    void Update()
    {
        MOving();
        Bounds();
        
    }
    public void MOving()
    {
        HorInput = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right  * Speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);

        }
    }
    public void Bounds()
    {
        if (transform.position.x > posX)
        {
            transform.position = new Vector3(posX, 0,0);
        }
        else if (transform.position.x < -posX)
        {
            transform.position = new Vector3(-posX, 0, 0);

        }
    }

    
}
