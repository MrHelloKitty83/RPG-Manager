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
    public float DayTimer;
    public float DayLength;


    public CropData selectedCropToPlant;

    //Singleton
    public static GameManager instance;

    public static event UnityAction<int>onNewDay;
/*
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
*/
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

    private void Update()
    {
        DayTimer += Time.deltaTime;
        if(DayTimer > DayLength) //Every 30 seconds
        {
            Debug.Log("New DAY! Day is:" + curDay);
            SetNextDay();
            DayTimer -= DayLength; //Subtract 30 seconds
        }
    }

    public void SetNextDay()
    {
        curDay++;
        onNewDay?.Invoke(curDay);
    }
    /*
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
    */
}
