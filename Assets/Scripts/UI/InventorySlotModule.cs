using System;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotModule : MonoBehaviour
{
    public event Action ActionRefreshSlotIcon;
    public EquipItemData _equipItemData;
    [SerializeField] private Image _equipIcon;
    [SerializeField] private Image _equipMarkIcon;

    public event Action ActionFalseEmarker;
    private void Awake()
    {
        InitSlotImage();
        ActionRefreshSlotIcon += RefreshSlotIcon;
    }
    private void Start()
    {
        ActionFalseEmarker += DisableEquipMarker;
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
    public void CallActionFalseEmarker()
    {
        ActionFalseEmarker?.Invoke();
    }
    public void DisableEquipMarker()
    {
        _equipMarkIcon.enabled = false;
    }

    public void OnDisable()
    {
        ActionRefreshSlotIcon = null;
    }

}
