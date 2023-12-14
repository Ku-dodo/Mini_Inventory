using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public enum JSONSerializeStat
{
    Saving,
    Loading,
    Done
}

public class JsonDataController : MonoBehaviour
{
    public static JsonDataController Instance;

    private string jsonPath = Application.dataPath + "/Resources/Data/inventoryData.json";
    private string jsonText;

    public InventoryData inventoryData;

    public JSONSerializeStat stats = JSONSerializeStat.Done;
    private void Awake()
    {
        Instance = this;
        LoadInventory();
    }

    public void SaveInventory()
    {
        stats = JSONSerializeStat.Saving;
        string inventoryJson = JsonUtility.ToJson(inventoryData, true);
        File.WriteAllText(jsonPath, inventoryJson);
        stats = JSONSerializeStat.Done;
    }
    public void LoadInventory()
    {
        stats = JSONSerializeStat.Loading;
        jsonText = File.ReadAllText(jsonPath);
        inventoryData = JsonUtility.FromJson<InventoryData>(jsonText);
        stats = JSONSerializeStat.Done;
    }
}
[System.Serializable]
public class InventoryData
{
    public List<SlotData> Inventory;
}
[System.Serializable]
public class SlotData
{
    public int ItemID;
    public int Count;
    public string EquipState;
}
