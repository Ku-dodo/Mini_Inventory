using System;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotModule : MonoBehaviour
{
    public event Action ActionRefreshSlotIcon;
    public EquipItemData _equipItemData;
    [SerializeField] private Image _equipIcon;
    [SerializeField] private Image _equipMarkIcon;

    public event Action ActionEquipMarkEnable;
    public event Action ActionEquipMarkDisable;


    public void Awake()
    {
        InitSlotImage();
        ActionRefreshSlotIcon += RefreshSlotIcon;
        ActionEquipMarkEnable += EquipMarkEnable;
        ActionEquipMarkDisable += EquipMarkDisable;
    }
    public void InitSlotImage()
    {
        _equipIcon.enabled = false;
        _equipMarkIcon.enabled = false;

    }
    private void RefreshSlotIcon()
    {
        if (_equipItemData != null)
        {
            _equipIcon.sprite = _equipItemData.icon;
            _equipIcon.enabled = true;
        }
        else if (_equipItemData == null)
        {
            _equipIcon.enabled = false;
        }
    }
    public void CallRefreshSlotIcon()
    {
        ActionRefreshSlotIcon?.Invoke();
    }

    private void EquipMarkEnable()
    {
        _equipMarkIcon.enabled = true;
    }

    public void CallEquipMarkEnable()
    {
        ActionEquipMarkEnable?.Invoke();
    }


    private void EquipMarkDisable()
    {
        _equipMarkIcon.enabled = true;
    }

    public void CallEquipMarkDisable()
    {
        ActionEquipMarkDisable?.Invoke();
    }
    public void OnDisable()
    {
        ActionRefreshSlotIcon = null;
    }

}
