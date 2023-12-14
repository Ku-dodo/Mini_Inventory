using System;
using System.Collections.Generic;
using UnityEngine;

public class EquipManager : MonoBehaviour
{
    public static EquipManager Instance;

    private Dictionary<string, EquipItemData> equipData = new Dictionary<string, EquipItemData>();
    private int _equipSumAtk;
    private int _equipSumDef;
    private int _equipSumHP;
    private float _equipSumSpeed;

    public int EquipSumATK { get => _equipSumAtk; }
    public int EquipSumDEF { get => _equipSumDef; }
    public int EquipSumHP { get => _equipSumHP; }
    public float EquipSumSpeed { get => _equipSumSpeed; }
   
    private Dictionary<string, EquipItemData> _equipmentDictionary;
    private void Awake()
    {
        Instance = this;
        _equipmentDictionary = new Dictionary<string, EquipItemData>();
        equipData.Add("Weapon", null);
        equipData.Add("Armor", null);
    }

    public void ChangeEquipItem(EquipItemData equipItemData)
    {
        if (equipItemData == null)
        {
            _equipmentDictionary["Weapon"] = null;
        }
        else if (equipItemData.equipType == ItemData.EquipType.Weapon)
        {
            Debug.Log("üũ ");
            _equipmentDictionary["Weapon"] = equipItemData;
        }
        else if (equipItemData.equipType == ItemData.EquipType.Armor)
        {
            _equipmentDictionary["Armor"] = equipItemData;
        }
        GetEquipStats();
    }

    public void GetEquipStats()
    {
        _equipSumAtk = 0;
        _equipSumDef = 0;
        _equipSumHP = 0;
        _equipSumSpeed = 0;

        foreach (var item in _equipmentDictionary)
        {
            if (item.Value != null)
            {
                _equipSumAtk += item.Value.equipATK;
                _equipSumDef += item.Value.equipDEF;
                _equipSumHP += item.Value.equipHP;
                _equipSumSpeed += item.Value.equipSpeed;
            }
        }
    }



}
