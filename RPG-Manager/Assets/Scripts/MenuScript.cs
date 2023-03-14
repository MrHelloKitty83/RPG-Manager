using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public InventorySlot slot;
    private PlayerControler playerControler;
    public Button initalFocusObject;
    InventorySlot[] slots = new InventorySlot[20];
    public GridLayoutGroup gridLayout;
    public Canvas myCanvas;
    private void Start()
    {
        playerControler = transform.parent.GetComponent<PlayerControler>();
        for (int i = 0;i<20;i++)
        {
            InventorySlot newSlot = Instantiate(slot);
            slots[i] = newSlot;
            newSlot.transform.SetParent(gridLayout.transform, false);
        }
        initalFocusObject = slots[0].GetComponent<Button>();
        playerControler.SwitchCurrentActionMap("Menu");
    }
    private void OnDisable()
    {

    }
    internal Button FirstSelected()
    {
        Debug.Log("Mew");
        return initalFocusObject;
    }
}
