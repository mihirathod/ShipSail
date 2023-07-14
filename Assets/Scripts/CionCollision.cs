using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CionCollision : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        CoinsCollector.Coinamount += 1;
        SoundScript.Playsound("CoinSound");   
    }
}
