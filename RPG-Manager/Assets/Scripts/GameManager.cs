using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public int curDay;
    public int money;
    public int cropInventory;

    public CropData selectedCropToPlant;

    public event UnityAction onNewDay;

    //Singleton
    public static GameManager instance;

    private void OnEnable()
    {
        Crops.onHarvestCrop += OnHarvestCrop;
        Crops.OnPlantCrop += OnPlantCrop;
    }

    private void OnDisable()
    {
        Crops.onHarvestCrop -= OnHarvestCrop;
        Crops.OnPlantCrop -= OnPlantCrop;
    }

    private void Awake()
    {
        if(instance != null && instance !=this) 
        {
            Destroy(gameObject);
        }
        else
        {
            instance= this; 
        }
    }

    public void SetNextDay()
    {
        
    }
    public void OnPlantCrop(CropData crop)
    {
        cropInventory--;
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
    private void UpdateStatsText()
    {
        
    }
}
