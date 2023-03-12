using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuTile : MonoBehaviour, IInteractable
{
    public Canvas ShopCanvas;

    public void Interact(PlayerStats player)
    {
        Debug.Log("Shop Tile");
        Canvas canvas = Instantiate(ShopCanvas);
        canvas.transform.SetParent(player.transform);
        canvas.enabled = true;
        canvas.worldCamera = player.camera;
        canvas.sortingLayerName = "Menu";
    }
}
