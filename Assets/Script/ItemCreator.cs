using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]

public class ScriptableItem : ScriptableObject
{
    public enum ItemType
    {
        Weapon,
        Armor,
    }
    public string itemName;
    public int itemPrice;
    public ItemType itemType;
    public Sprite itemSprite;
    
}
