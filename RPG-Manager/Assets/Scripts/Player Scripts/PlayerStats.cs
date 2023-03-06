using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public CropData crop;
    public TextMeshProUGUI statsText;
    public int cropInventory;
    public int money;
    public int PlayerID;


    private void OnEnable()
    {
        Crops.onHarvestCrop += OnHarvestCrop;
        Crops.onPlantCrop += OnPlantCrop;
        GameManager.onNewDay += OnNewDay;
    }

    private void OnNewDay(int day)
    {
        updateStatsText();
    }

    private void OnDisable()
    {
        Crops.onHarvestCrop -= OnHarvestCrop;
        Crops.onPlantCrop -= OnPlantCrop;
    }


    public void OnPlantCrop(CropData crop)
    {
        if (crop.PlayerID == PlayerID)
        {
            cropInventory--;
            Debug.Log("Crops Left:" + cropInventory + " for player ID:" + PlayerID);
            updateStatsText();
        }
    }
    public void OnHarvestCrop(CropData crop)
    {
        money += crop.sellPrice;
        updateStatsText();
    }
    public void PurchaseCrop()
    {

    }
    public bool CanPlantCrop()
    {
        return cropInventory > 0;
    }
    private void updateStatsText()
    {
        statsText.text = "Day: "+ GameManager.instance.curDay+ "\n";
        statsText.text += "Crop Inventory: " + cropInventory + "\n";
        statsText.text += "Money: " + money;
        
    }
}
