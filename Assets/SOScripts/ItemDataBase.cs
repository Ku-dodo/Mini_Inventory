using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ItemDataBase", menuName ="ItemSO/ItemDataBase")]

public class ItemDataBase : ScriptableObject
{
    public List<EquipItemData> data;
}
