using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonPrefab : MonoBehaviour
{
    public Button button; // ��ư ������Ʈ�� ����Ű�� �ʵ�
    public TMP_Text buttonText; // ��ư �ؽ�Ʈ ������Ʈ�� ����Ű�� �ʵ�

    public void SetText(string text)
    {
        buttonText.text = text;
    }
}