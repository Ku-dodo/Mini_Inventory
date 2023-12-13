using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsOperator : MonoBehaviour
{
    public static StatsOperator Instance;
    private int _totalATK;
    private int _totalDEF;
    private int _totalHP;
    private float _totalSpeed;

    public int TotalATK {  get { return _totalATK; } }
    public int TotalDEF { get { return _totalDEF;} }
    public int TotalHP { get { return _totalHP;} }
    public float TotalSpeed { get { return _totalSpeed;} }

    private GameObject _player; 
    private PlayerDefinition _playerDefinition;
    private EquipManager _equipManager;
    private void Awake()
    {
        Instance = this;
        _player = GameObject.FindGameObjectWithTag("Player");
        _playerDefinition = _player.GetComponent<PlayerDefinition>();
    }

    public void SetCalcStats()
    {
        _totalATK = _playerDefinition.playerBaseATK + EquipManager.Instance.EquipSumATK;
        _totalDEF = _playerDefinition.playerBaseDEF + EquipManager.Instance.EquipSumDEF;
        _totalHP = _playerDefinition.playerMaxHP + EquipManager.Instance.EquipSumHP;
        _totalSpeed = _playerDefinition.playerBaseSpeed + EquipManager.Instance.EquipSumSpeed;
    }
}
