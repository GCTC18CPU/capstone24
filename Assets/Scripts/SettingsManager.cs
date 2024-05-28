using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Slider volumeSlider;

    private void Start()
    {
        // 초기 설정된 볼륨 값을 슬라이더에 반영
        volumeSlider.value = AudioListener.volume;
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
        // 데이터 삭제 후 초기화 로직
        GameManager.Instance.StartGame();
    }
}
