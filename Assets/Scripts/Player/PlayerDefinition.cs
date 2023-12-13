using UnityEngine;

public class PlayerDefinition : MonoBehaviour
{
    public PlayerInfo _playerInfo;

    [SerializeField] private int _maxHP;
    [SerializeField] private int _baseAtk;
    [SerializeField] private int _baseDef;
    [SerializeField] private float _baseSpeed;

    public int playerMaxHP { get => _maxHP; }
    public int playerBaseATK { get => _baseAtk; }
    public int playerBaseDEF { get => _baseDef; }
    public float playerBaseSpeed { get => _baseSpeed; }
}
