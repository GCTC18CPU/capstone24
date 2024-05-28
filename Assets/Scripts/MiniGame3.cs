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
        // ���� ���� �˾� ����
        Debug.Log("Game Over");
        // GameManager.Instance.LoadMainScene();
    }

    void ShowGameClearPopup()
    {
        // ���� Ŭ���� �˾� ����
        Debug.Log("Game Clear");
        // GameManager.Instance.LoadMainScene();
    }
}
