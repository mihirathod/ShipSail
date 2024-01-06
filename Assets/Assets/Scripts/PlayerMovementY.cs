using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMovementY : MonoBehaviour
{

    public bool IsButtonsOn;
    public float DirX;
    private float MoveForwardSpeed = 10f;
    public GameObject Controls;
    public Rigidbody playerrb;
    public float posX;
    public float speed;
    void Start()
    {
        playerrb.GetComponent<Rigidbody>();
    }
    void Update()
    {


        DirX = CrossPlatformInputManager.GetAxis("Horizontal") * MoveForwardSpeed;
        transform.Translate(Vector3.left * DirX * speed* Time.deltaTime);
        Bounds();

    }

    public void Bounds()
    {
        if (transform.position.x > posX)
        {
            transform.position = new Vector3(posX, 0, 0);
        }
        else if (transform.position.x < -posX)
        {
            transform.position = new Vector3(-posX, 0, 0);

        }
    }



    
}
