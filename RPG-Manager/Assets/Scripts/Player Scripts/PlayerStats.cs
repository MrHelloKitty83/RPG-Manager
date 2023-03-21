using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public CropData crop;
    public int cropInventory;
    public int money;
    public int PlayerID;
    public Camera camera;
    private void OnEnable()
    {
        Crops.onHarvestCrop += OnHarvestCrop;
        Crops.onPlantCrop += OnPlantCrop;
        GameManager.onNewDay += OnNewDay;
    }

    private void OnNewDay(int day)
    {

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
        }
    }
    public void OnHarvestCrop(CropData crop)
    {
        money += crop.sellPrice;
    }
    public void PurchaseCrop()
    {

    }
    public bool CanPlantCrop()
    {
        return cropInventory > 0;
    }
}
