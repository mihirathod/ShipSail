using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip CoinSound;
    public static AudioSource AudSrc;
    // Start is called before the first frame update
    void Start()
    {
        CoinSound = Resources.Load<AudioClip>("CoinSound");
        AudSrc = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void Playsound(string clip)
    {switch (clip)
        {
            case "CoinSound":
                AudSrc.PlayOneShot(CoinSound);
                break;
        }           
    }
}
