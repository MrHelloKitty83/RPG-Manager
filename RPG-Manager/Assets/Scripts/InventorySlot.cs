using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public Item myItem;
    public Sprite mySprite;
    public Sprite myDefaultSprite;
    public TextMeshProUGUI stackText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateGUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateGUI()
    {
        if (myItem == null)
        {
            mySprite = myItem.sprite;
            if (myItem.isStackable)
            {
                stackText.text = myItem.stackSize.ToString();
                stackText.enabled = true;
            }
        }
        else
        {
            mySprite = myDefaultSprite;
            stackText.enabled = false;
        }
    }
}
