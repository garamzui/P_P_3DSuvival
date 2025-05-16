
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager _instance;
    public static CharacterManager Instance
    {
        get
        {
            //������Ʈ â�� ������Ʈ�� ���߷��� �ϳ� ���� ��ũ��Ʈ�� �ְ� ��ȯ���ִ� ��� �ڵ� 
            if (_instance == null)
            { _instance = new GameObject("ChatacterManager").AddComponent<CharacterManager>(); }
            return _instance;
        }
    }
    public Player _player;
    public Player Player
    {
        get { return _player; } //=>_player
        set {_player = value; }
    }
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(_instance == this)
                Destroy(gameObject);
        }
    }
}
