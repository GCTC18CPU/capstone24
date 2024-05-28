using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopupPrefab : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;
    public Button nextButton;

    public void SetTitle(string title)
    {
        titleText.text = title;
    }

    public void SetContent(string content)
    {
        contentText.text = content;
    }

    public void SetNextButtonAction(UnityEngine.Events.UnityAction action)
    {
        nextButton.onClick.RemoveAllListeners();
        nextButton.onClick.AddListener(action);
    }
}