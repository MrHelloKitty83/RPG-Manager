using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Item",menuName ="Item/Create New Item")]
public class Item : ScriptableObject,IInventoyItem
{
    public Sprite Sprite;
    public bool IsStackable;
    public int StackMax;
    public int StackSize;
    public int StackSizeMod;
    public string Description;
    public Sprite sprite { get => Sprite; set => Sprite = value; }
    public bool isStackable { get => IsStackable ; set => IsStackable = value; }
    public int stackMax { get => StackMax; set => StackMax = value; }
    public int stackSize { get => StackSize; set => StackSize = value; }
    public int stackSizeMod { set => stackSize += value; }
    public string description { get => Description; set =>  Description= value; }
}
