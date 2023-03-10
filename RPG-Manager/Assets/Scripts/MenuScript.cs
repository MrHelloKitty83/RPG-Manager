using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public InventorySlot slot;
    public Button initalFocusObject;
    InventorySlot[] slots = new InventorySlot[20];
    public GridLayoutGroup gridLayout;
    private void Start()
    {
        Debug.Log("MenuScript");
        for (int i = 0;i<20;i++)
        {
            InventorySlot newSlot = Instantiate(slot);
            slots[i] = newSlot;
            newSlot.transform.SetParent(gridLayout.transform, false);
        }
        initalFocusObject = slots[0].GetComponent<Button>();
    }
    private void OnEnable()
    {
        
    }

    private void SetFocus()
    {
        initalFocusObject.Select();
    }
}
