using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float Xpos;
    public float Zpos;
    public float Delay;
    public float spwnInterval;

    void Start()
    {
        InvokeRepeating("Spawner", Delay, spwnInterval);
    }
    public void Spawner()
    {
        Vector3 Spwnpos = new Vector3(Random.Range(-Xpos,Xpos), 0, Zpos);
        int ObstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Instantiate(obstaclePrefabs[ObstacleIndex], Spwnpos,
            obstaclePrefabs[ObstacleIndex].transform.rotation);
    }
}
