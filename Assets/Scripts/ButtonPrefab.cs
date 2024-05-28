using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonPrefab : MonoBehaviour
{
    public Button button; // 버튼 컴포넌트를 가리키는 필드
    public TMP_Text buttonText; // 버튼 텍스트 컴포넌트를 가리키는 필드

    public void SetText(string text)
    {
        buttonText.text = text;
    }
}