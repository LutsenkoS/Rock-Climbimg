using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider VolumeSlider;
    public Slider TextureSlider;
    
    public float Volume
    {
        get { return _volume; }
        set
        {
            _volume = value;
            OnVolumeChanged();
        }
    }

    public int TextureQuality
    {
        get { return _textureQuality; }
        set
        {
            _textureQuality = value;
            OnTextureQualityChanged();
        }
    }

    private Text _qualityText;
    private float _volume;
    private int _textureQuality;
    void Start()
    {     
        VolumeSlider.value = GameController.Instance.Volume;
        TextureSlider.value = GameController.Instance.TextureQuality;
        _qualityText = TextureSlider.GetComponentInChildren<Text>();
    }

    void Update()
    {      
        if (Volume != VolumeSlider.value)
            Volume = VolumeSlider.value;
        if (TextureQuality != (int) TextureSlider.value)
            TextureQuality = (int)TextureSlider.value;

    }
    private void OnVolumeChanged()
    {
        GameController.Instance.Volume = Volume;
    }
    private void OnTextureQualityChanged()
    {
        GameController.Instance.TextureQuality = TextureQuality;
        QualitySettings.SetQualityLevel(TextureQuality, true);
        switch (TextureQuality)
        {
            case 0:
                _qualityText.text = "Fastest";
                break;
            case 1:
                _qualityText.text = "Fast";
                break;
            case 2:
                _qualityText.text = "Simple";
                break;
            case 3:
                _qualityText.text = "Good";
                break;
            case 4:
                _qualityText.text = "Beautiful";
                break;
            case 5:
                _qualityText.text = "Fantastic";
                break;
            default: _qualityText.text = "";
                break;
        }
    }
}
