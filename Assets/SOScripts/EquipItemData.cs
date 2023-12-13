using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Item", menuName = "ItemSO/EquipItemData")]
public class EquipItemData : ItemData
{
    [Header("Stats")]
    public int equipHP;
    public int equipATK;
    public int equipDEF;
    public float equipSpeed;
}
