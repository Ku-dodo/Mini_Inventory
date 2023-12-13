using UnityEngine;

public class ItemData : ScriptableObject
{
    public enum EquipType
    {
        Weapon,
        Armor
    }

    [Header("Info")]
    public int itemID;
    public string itemName;
    public string description;
    public Sprite icon;
    public EquipType equipType;

    [Header("Stackable")]
    public bool canStack;
    public int maxStackAmount;

}
