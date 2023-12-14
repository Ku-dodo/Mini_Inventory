using System;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlotContainer : MonoBehaviour
{
    private List<GameObject> _inventorySlots = new List<GameObject>();

    public event Action ActionResetSlotEquipMarker;

    private void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            _inventorySlots.Add(transform.GetChild(i).gameObject);
        }
        foreach (GameObject item in _inventorySlots)
        {
            item.GetComponent<InventorySlotModule>()._equipItemData = null;
        }
    }
    private void Start()
    {
        ActionResetSlotEquipMarker += ResetSlotEquipMarker;
            SetItemList();
    }
    private void SetItemList()
    {
        for (int i = 0; i < JsonDataController.Instance.inventoryData.Inventory.Count && i <_inventorySlots.Count; i++)
        {
            _inventorySlots[i].gameObject.GetComponent<InventorySlotModule>()._equipItemData = 
                Resources.Load<EquipItemData>($"Data/{JsonDataController.Instance.inventoryData.Inventory[i].ItemID.ToString()}");
            _inventorySlots[i].gameObject.GetComponent<InventorySlotModule>().CallRefreshSlotIcon();
        }
    }

    public void CallResetSlotEquipMarker()
    {
        ActionResetSlotEquipMarker?.Invoke();
    }

    public void ResetSlotEquipMarker()
    {
        foreach (GameObject item in _inventorySlots)
        {
            item.GetComponent<InventorySlotModule>().CallActionFalseEmarker();
        }
    }
    
}
