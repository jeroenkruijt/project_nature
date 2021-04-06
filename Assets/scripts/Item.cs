using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        plastic,
        glas,
        papier,
        rest,
    }

    public ItemType itemType;
    public int amount;
}
