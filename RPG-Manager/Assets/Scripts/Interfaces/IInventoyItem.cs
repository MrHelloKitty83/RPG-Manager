using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventoyItem
{
    public Sprite sr { get; set; }
    public bool isStackable { get; set; }
    public int stackMax { get; set; }
    public int stackSize { get; set; }
    public int stackSizeAdjust {set => stackSize+=value; }
    public string description { get; set; }
}
