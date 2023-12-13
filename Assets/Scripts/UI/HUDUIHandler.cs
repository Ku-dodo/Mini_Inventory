using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDUIHandler : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _userJob;
    [SerializeField] private TextMeshProUGUI _userName;
    [SerializeField] private TextMeshProUGUI _userDescription;
    [SerializeField] private TextMeshProUGUI _userLevel;
    [SerializeField] private TextMeshProUGUI _userExp;
    [SerializeField] private Slider _expSlider;

    private GameObject _player;
    private PlayerDefinition _playerDefinition;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _playerDefinition = _player.GetComponent<PlayerDefinition>();
        SetUserInfoText();
    }

    public void SetUserInfoText()
    {
        _userJob.text = _playerDefinition._playerInfo.JobName;
        _userName.text = _playerDefinition._playerInfo.UserName;
        _userDescription.text = _playerDefinition._playerInfo.JobDescription;
        _userLevel.text = _playerDefinition._playerInfo.UserLv.ToString();
        _userExp.text = $"{_playerDefinition._playerInfo.UserCurEXP}/{_playerDefinition._playerInfo.UserMaxEXP}";
        _expSlider.value = (float)_playerDefinition._playerInfo.UserCurEXP / _playerDefinition._playerInfo.UserMaxEXP;
    }

}
