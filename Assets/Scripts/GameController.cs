using UnityEngine;

public class GameController : MonoBehaviour
{
    public float Volume { get; set; }
    public int TextureQuality { get; set; }
    public static GameController Instance
    {
        get { return _instance; }
    }

    private static GameController _instance = null;

    void Awake()
    {
        //singleton pattern
        if (_instance)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(gameObject);
        //default values of settings
        Volume = 0.5f;
        TextureQuality = 4;        
    }

}
