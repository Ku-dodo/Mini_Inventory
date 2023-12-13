using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupUIDestroy : MonoBehaviour
{
    private GameObject _parentsPopupUI;
    private void Start()
    {
        _parentsPopupUI = transform.parent.gameObject;
    }
    public void DestroyParentPopup()
    {
        Destroy(_parentsPopupUI);
    }
}
