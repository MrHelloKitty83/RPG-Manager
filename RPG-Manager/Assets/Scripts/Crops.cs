using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Crops : MonoBehaviour
{
    private CropData curCrop;
    private int plantDay;
    private int daysSinceLastWatered;

    public SpriteRenderer sr;

    public static event UnityAction<CropData> OnPlantCrop;
    public static event UnityAction<CropData> onHarvestCrop;

    public void Plant (CropData crop)
    {
        curCrop = crop;
        plantDay = GameManager.instance.curDay;
        daysSinceLastWatered = 1;
        UpdateCropSprite();

        OnPlantCrop?.Invoke(crop);
    }

    public void NewDayCheck()
    {
        if(daysSinceLastWatered > 3)
        {
            Destroy(gameObject);
        }
        UpdateCropSprite();
    }

    private void UpdateCropSprite()
    {
        int cropProg = CropProgress();

        if (cropProg < curCrop.daysToGrow)
        { 
            sr.sprite = curCrop.gropProgressSprites[cropProg];
        }
        else
        {
            sr.sprite = curCrop.readyToHarvestSprite;
        }
    }

    public void Water ()
    {
        daysSinceLastWatered = 0;
    }

    public void Harvest()
    {
        if(CanHarvest())
        {
            onHarvestCrop?.Invoke(curCrop);
            Destroy(gameObject);
        }
    }

    int CropProgress()
    {
        return GameManager.instance.curDay-plantDay;
    }

    public bool CanHarvest()
    {
        return CropProgress() >= curCrop.daysToGrow;
    }
}
