using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public GameObject gameOverPopup;
    public GameObject gameClearPopup;
    public GameObject equipPopup;

    public void ShowGameOverPopup()
    {
        gameOverPopup.SetActive(true);
    }

    public void ShowGameClearPopup()
    {
        gameClearPopup.SetActive(true);
    }

    public void ShowEquipPopup()
    {
        equipPopup.SetActive(true);
    }
}
