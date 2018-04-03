using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHelper : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start()
    {      
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = GameController.Instance.Volume;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(0);
    }
	
}
