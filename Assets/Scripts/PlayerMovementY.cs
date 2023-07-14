using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovementY : MonoBehaviour
{
    public bool IsButtonsOn;
    public Rigidbody Playerrb;
    public float DirZ;
    private float MoveForwardSpeed  = 20f ;
    public GameObject Controls;
    void Start()
    {
        Playerrb = GetComponent<Rigidbody>();
    }
    void Update()
    {
            DirZ = CrossPlatformInputManager.GetAxis("Horizontal") * MoveForwardSpeed;
            Playerrb.velocity = new Vector3(0f, 0f, DirZ);
    }
}
