using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotBtn : MonoBehaviour
{
    [SerializeField] private Image _equipMarker;
    private InventorySlotContainer container;
    public int btnIndex;
    private void Start()
    {
        container = transform.parent.GetComponent<InventorySlotContainer>();
        _equipMarker.enabled = false;
        if (btnIndex < JsonDataController.Instance.inventoryData.Inventory.Count)
        {
            if (JsonDataController.Instance.inventoryData.Inventory[btnIndex].EquipState == "Equiped")
            {
                _equipMarker.enabled = true;
            }
        }

    }
    public void SlotClickEvent()
    {
        if (gameObject.GetComponent<InventorySlotModule>()._equipItemData == null)
        {
            Debug.Log("üũ 55");
            return;
        }
        container.CallResetSlotEquipMarker();
        if (JsonDataController.Instance.inventoryData.Inventory[btnIndex].EquipState == "Equiped")
        {
            JsonDataController.Instance.inventoryData.Inventory[btnIndex].EquipState = "UnEquiped";
            EquipManager.Instance.ChangeEquipItem(null);
            _equipMarker.enabled = false;
        }
        else if (JsonDataController.Instance.inventoryData.Inventory[btnIndex].EquipState == "UnEquiped")
       {
            JsonDataController.Instance.inventoryData.Inventory[btnIndex].EquipState = "Equiped";
            EquipManager.Instance.ChangeEquipItem(gameObject.GetComponent<InventorySlotModule>()._equipItemData);
            _equipMarker.enabled = true;
        }
        JsonDataController.Instance.SaveInventory();
        JsonDataController.Instance.LoadInventory();

    }
}
