using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupUICreate : MonoBehaviour
{
    [SerializeField] private GameObject _popupUI;
    [SerializeField] private GameObject _popupUIParent;
    public void CreatePopupUI()
    {
        Instantiate(_popupUI, _popupUIParent.transform);
    }
}
