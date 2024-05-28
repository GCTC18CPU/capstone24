using UnityEngine;

public class MiniGame3 : MonoBehaviour
{
    private bool isGameOver = false;
    private bool isGameClear = false;

    void Update()
    {
        if (isGameOver)
        {
            ShowGameOverPopup();
        }

        if (isGameClear)
        {
            ShowGameClearPopup();
        }
    }

    public void EndGame(bool success)
    {
        if (success)
        {
            isGameClear = true;
        }
        else
        {
            isGameOver = true;
        }
    }

    void ShowGameOverPopup()
    {
        // 게임 오버 팝업 로직
        Debug.Log("Game Over");
        // GameManager.Instance.LoadMainScene();
    }

    void ShowGameClearPopup()
    {
        // 게임 클리어 팝업 로직
        Debug.Log("Game Clear");
        // GameManager.Instance.LoadMainScene();
    }
}
