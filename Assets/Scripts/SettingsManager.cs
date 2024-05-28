using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Slider volumeSlider;

    private void Start()
    {
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
        // 데이터 삭제 후 초기화 로직 추가
        GameManager.Instance.StartGame();
    }
}

