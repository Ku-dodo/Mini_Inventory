using System.Collections.Generic;
using UnityEngine;

public class InventorySlotContainer : MonoBehaviour
{
    private List<GameObject> _inventorySlots = new List<GameObject>();

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
        SetItemList();
    }
    private void SetItemList()
    {
        for (int i = 0; i < Resources.Load<ItemDataBase>("Data/ItemDataBase").data.Count; i++)
        {
            _inventorySlots[i].gameObject.GetComponent<InventorySlotModule>()._equipItemData = Resources.Load<ItemDataBase>("Data/ItemDataBase").data[i];
            _inventorySlots[i].gameObject.GetComponent<InventorySlotModule>().CallRefreshSlotIcon();
        }
    }
}
