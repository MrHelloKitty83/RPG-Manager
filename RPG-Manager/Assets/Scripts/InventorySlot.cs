using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item myItem;
    public Image myImage;
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
        Debug.Log("Im a wheat slot!");
        if (myItem != null)
        {
            Debug.Log("I have an item!");
            myImage.sprite = myItem.sprite;
            if (myItem.isStackable)
            {
                stackText.text = myItem.stackSize.ToString();
                stackText.enabled = true;
            }
            else
            {
                stackText.enabled = false;
            }
        }
        else
        {
            myImage.sprite = myDefaultSprite;
            stackText.enabled = false;
        }
    }
}
