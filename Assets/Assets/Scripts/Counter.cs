using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public float ScoreAmount;
    public float IncreasePerSec;
    // Start is called before the first frame update
    void Start()
    {
        ScoreAmount = 0f;
        IncreasePerSec = 10f;

    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score:" + (int)ScoreAmount;
        ScoreAmount += IncreasePerSec * Time.deltaTime;
    }  

    
}
