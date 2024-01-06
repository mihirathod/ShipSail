using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float DestroyBound;
    public float Forwardspeed;
    public float IncreaseinSpeed;
    void Update()
    {
        Forwardspeed += IncreaseinSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * Forwardspeed * Time.deltaTime);
        DestroyOutOFBounds();
    }
    public void DestroyOutOFBounds()
    {
        if (transform.position.z < DestroyBound)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        Time.timeScale = 0f;
        FindObjectOfType<Gamemanager>().EndGame();
    }
}
