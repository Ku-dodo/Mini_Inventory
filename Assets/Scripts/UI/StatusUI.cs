using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatusUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _statusUIATK;
    [SerializeField] private TextMeshProUGUI _statusUIDEF;
    [SerializeField] private TextMeshProUGUI _statusUIHP;
    [SerializeField] private TextMeshProUGUI _statusUISpeed;

    private void Start()
    {
        StatsOperator.Instance.SetCalcStats();
        _statusUIATK.text = StatsOperator.Instance.TotalATK.ToString();
        _statusUIDEF.text = StatsOperator.Instance.TotalDEF.ToString();
        _statusUIHP.text = StatsOperator.Instance.TotalHP.ToString();
        _statusUISpeed.text = StatsOperator.Instance.TotalSpeed.ToString("N1");
    }
}
