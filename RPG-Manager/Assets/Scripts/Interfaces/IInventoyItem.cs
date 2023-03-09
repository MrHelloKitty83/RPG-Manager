using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInventoyItem
{
    public Sprite sprite();
    public string description();
    public bool stackable();
    public int stackSize();
    public int stackMax();
}
