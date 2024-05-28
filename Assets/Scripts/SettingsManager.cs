using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Slider volumeSlider;

    private void Start()
    {
        // �ʱ� ������ ���� ���� �����̴��� �ݿ�
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
        // ������ ���� �� �ʱ�ȭ ����
        GameManager.Instance.StartGame();
    }
}
