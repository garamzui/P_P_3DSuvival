
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager _instance;
    public static CharacterManager Instance
    {
        get
        {
            //프로젝트 창에 오브젝트를 빠뜨려도 하나 만들어서 스크립트를 넣고 반환해주는 방어 코드 
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
