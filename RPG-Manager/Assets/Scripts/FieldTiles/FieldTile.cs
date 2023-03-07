using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FieldTile : MonoBehaviour, IInteractable
{
    private Crops curCrop;

    public GameObject cropPrefab;
    public SpriteRenderer sr;

    private bool tilled;

    [Header("Sprites")]
    public Sprite grassSprite;
    public Sprite tilledSprite;
    public Sprite wateredTilledSprite;

    private void Start()
    {
        //Set Default Grass Sprite
        sr.sprite = grassSprite;
    }
    public void Interact (PlayerStats player)
    {
        if(!tilled)
        {
            Till();
        }
        else if(!HasCrop() && player.CanPlantCrop())
        {
            CropData newcrop = player.crop;
            newcrop.PlayerID = player.PlayerID;
            PlantNewCrop(newcrop);
        }
        else if (HasCrop() && curCrop.CanHarvest())
        {
            curCrop.Harvest();
        }else
        {
            Water();
        }
    }

    void PlantNewCrop(CropData crop)
    {
        if(!tilled) { return; }

        curCrop = Instantiate(cropPrefab,transform).GetComponent<Crops>();
        curCrop.Plant(crop);
        GameManager.onNewDay += OnNewDay;
    }

    void Till()
    {
        tilled = true;
        sr.sprite = tilledSprite;
    }

    void Water()

    {
        sr.sprite = wateredTilledSprite;

        if (HasCrop())
        {
            curCrop.Water();
        }
    }

    void OnNewDay(int player)
    {
        Debug.Log("Tile found new day.");
        if(curCrop==null)
        {
            tilled = false;
            sr.sprite = grassSprite;

            GameManager.onNewDay -= OnNewDay;
        }
        else if(curCrop != null)
        {
            sr.sprite = tilledSprite;
            curCrop.NewDayCheck();
        }

    }

    bool HasCrop()
    {
        return curCrop != null;
    }
}
