using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTile : MonoBehaviour, IInteractable
{
    public void Interact(PlayerStats player)
    {
        Debug.Log("Menu Tile!");
    }

}
