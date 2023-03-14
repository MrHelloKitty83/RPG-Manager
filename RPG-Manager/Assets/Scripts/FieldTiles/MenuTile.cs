using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuTile : MonoBehaviour, IInteractable
{
    public MenuScript menu;

    public void Interact(PlayerStats player)
    {
        Debug.Log("Shop Tile");
        GameObject newMenu = Instantiate(menu.gameObject);
        MultiplayerEventSystem eventSystem = player.GetComponentInChildren<MultiplayerEventSystem>();
        Canvas canvas = newMenu.GetComponentInParent<Canvas>();
        newMenu.transform.SetParent(player.transform);
        canvas.enabled = true;
        canvas.worldCamera = player.camera;
        canvas.sortingLayerName = "Menu";
        eventSystem.playerRoot = newMenu;
        eventSystem.firstSelectedGameObject = menu.FirstSelected().gameObject;
        Debug.Log("Meow");
    }
}
