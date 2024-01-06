using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shopmanager : MonoBehaviour
{
    public ShipSystem[] Ships;

    private int CurrentShip = 0;
    public GameObject[] Shipsmodel;
    public Button BuyButton;

    void Start()
    { foreach (ShipSystem Ship in Ships)
        {
            if (Ship.Price == 0)
                Ship.IsUnloacked = true;
            else
                Ship.IsUnloacked = PlayerPrefs.GetInt(Ship.Name, 0) == 0 ? false : true;

        }


        CurrentShip = PlayerPrefs.GetInt("SelectedShip", 0);
        foreach (GameObject ship in Shipsmodel)
            ship.SetActive(false);

        Shipsmodel[CurrentShip].SetActive(true);

    }
    void Update()
    {
        UpdateUi();
    }
    public void next()
    {
        Shipsmodel[CurrentShip].SetActive(false);

        CurrentShip++;
        if (CurrentShip == Shipsmodel.Length)
            CurrentShip = 0;

        Shipsmodel[CurrentShip].SetActive(true);
        ShipSystem S = Ships[CurrentShip];
        if (!S.IsUnloacked)
            return;

        PlayerPrefs.SetInt("SelectedShip", CurrentShip);
    }
    public void Previous()
    {
        Shipsmodel[CurrentShip].SetActive(false);

        CurrentShip--;
        if (CurrentShip == -1)
            CurrentShip = Shipsmodel.Length - 1;
        Shipsmodel[CurrentShip].SetActive(true);
        ShipSystem S = Ships[CurrentShip];
        if (!S.IsUnloacked)
            return;

        PlayerPrefs.SetInt("SelectedShip", CurrentShip);
    }
    public  void UnlockShip()
    {
        ShipSystem S = Ships[CurrentShip];
        PlayerPrefs.SetInt(S.Name, 1);
        PlayerPrefs.SetInt("SelectedShip" , CurrentShip );
        S.IsUnloacked = true;
        PlayerPrefs.SetInt("Coinamount", PlayerPrefs.GetInt("Coinamount",0) - S.Price);
       
    }

    public void UpdateUi()
    {
        ShipSystem S = Ships[CurrentShip];  
        if (S.IsUnloacked)
        {
            BuyButton.gameObject.SetActive(false);  
        }
        else
        {
            BuyButton.gameObject.SetActive(true);
            BuyButton.GetComponentInChildren<TextMeshProUGUI>().text = "Buy-" + S.Price;
            if (S.Price <= PlayerPrefs.GetInt("Coinamount",0))
            {
                BuyButton.interactable = true;
            }
            else
            {
                BuyButton.interactable = false;
            }
            
        }
    }
}
