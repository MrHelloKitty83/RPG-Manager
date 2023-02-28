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
    public void OnPlantCrop()
    {

    }
    public void OnHarvestCrop()
    {

    }
    public void PurchaseCrop()
    {

    }
    public bool CanPlantCrop()
    {
        return true;
    }
    public void OnMouseUpAsButton()
    {
        
    }
    private void UpdateStatsText()
    {
        
    }
}
