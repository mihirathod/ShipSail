using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSelector : MonoBehaviour
{
    private int CurrentShip = 0;
    public GameObject[] Ships;

    void Start()
    {
        CurrentShip = PlayerPrefs.GetInt("SelectedShip", 1);
        foreach (GameObject ship in Ships)
            ship.SetActive(false);

        Ships[CurrentShip].SetActive(true);
    }
}
