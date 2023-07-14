using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collisions : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        Time.timeScale = 0f;
        FindObjectOfType<Gamemanager>().EndGame();
    }
}
