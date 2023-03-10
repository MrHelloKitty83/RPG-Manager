using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New SeedItem",menuName = "Item/Create Seed Item")]
public class SeedItem: Item
{
    public int buyValue = 0;
    public int sellValue = 0;
}
