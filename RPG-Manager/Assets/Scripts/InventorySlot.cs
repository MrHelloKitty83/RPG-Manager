using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class InventorySlot : MonoBehaviour
{
    IInventoyItem Item;
    TextMeshPro StackCount;
    Image ItemImage;

    void setItem(IInventoyItem newItem)
    {
        Item= newItem;
    }

    void updateItem()
    {
        if (Item.stackable())
        {
            StackCount.enabled = true;
            StackCount.text = Item.stackSize().ToString();
        }
        else
        {
            StackCount.enabled = false;
            StackCount.text = string.Empty;
        }
        ItemImage.sprite = Item.sprite();
    }
}
