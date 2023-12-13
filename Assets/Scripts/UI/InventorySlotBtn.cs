using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotBtn : MonoBehaviour
{
    [SerializeField] private Image _equipMarker;

    public void SlotClickEvent()
    {
        _equipMarker.enabled = true;
        EquipManager.Instance.ChangeEquipItem(gameObject.GetComponent<InventorySlotModule>()._equipItemData);
    }

}
