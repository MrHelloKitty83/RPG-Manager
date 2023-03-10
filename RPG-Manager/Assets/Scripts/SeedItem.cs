using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedItem: IInventoyItem
{
    int buyValue = 0;
    int sellValue = 0;

    public Sprite sr { get; set ; }
    public bool isStackable { get; set; }
    public int stackMax { get; set; }
    public int stackSize { get; set; }
    public string description { get; set; }
}
