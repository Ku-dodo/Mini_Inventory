using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerInfo", menuName = "PlayerInfo")]
public class PlayerInfo : ScriptableObject
{
    [Header("Player Info")]
    [SerializeField] private string _jobName;
    [SerializeField] private string _userName;
    [SerializeField] private int _userLv;
    [SerializeField] private int _maxEXP;
    [SerializeField] private int _curEXP;
    [SerializeField] private string _jobDescription;

    public int Gold { get; set; }
    public string JobName { get => _jobName;}
    public string UserName {  get => _userName;}
    public int UserLv { get => _userLv;}
    public int UserMaxEXP { get => _maxEXP;}
    public int UserCurEXP { get => _curEXP;}
    public string JobDescription { get => _jobDescription;}
}
