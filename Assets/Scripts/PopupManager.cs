using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopupManager : MonoBehaviour
{
    public GameObject gameOverPopup;
    public GameObject gameClearPopup;
    public GameObject equipPopup;
    public GameObject gamePurposePopup;
    public GameObject[] miniGameDescriptionPopups;

    public TextMeshProUGUI[] gamePurposeTexts; // 각 페이지의 텍스트
    private int currentGamePurposePage = 0;

    public TextMeshProUGUI[][] miniGameDescriptionTexts; // 각 미니게임 페이지의 텍스트
    private int[] currentMiniGamePages;

    private static PopupManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static PopupManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PopupManager>();
            }
            return instance;
        }
    }

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

    public void ShowGamePurposePopup()
    {
        gamePurposePopup.SetActive(true);
        currentGamePurposePage = 0;
        UpdateGamePurposePopup();
    }

    public void ShowMiniGameDescriptionPopup(int index)
    {
        if (index >= 0 && index < miniGameDescriptionPopups.Length)
        {
            miniGameDescriptionPopups[index].SetActive(true);
            currentMiniGamePages[index] = 0;
            UpdateMiniGameDescriptionPopup(index);
        }
    }

    public void NextGamePurposePage()
    {
        if (currentGamePurposePage < gamePurposeTexts.Length - 1)
        {
            currentGamePurposePage++;
            UpdateGamePurposePopup();
        }
    }

    public void NextMiniGameDescriptionPage(int index)
    {
        if (index >= 0 && index < miniGameDescriptionPopups.Length && currentMiniGamePages[index] < miniGameDescriptionTexts[index].Length - 1)
        {
            currentMiniGamePages[index]++;
            UpdateMiniGameDescriptionPopup(index);
        }
    }

    private void UpdateGamePurposePopup()
    {
        for (int i = 0; i < gamePurposeTexts.Length; i++)
        {
            gamePurposeTexts[i].gameObject.SetActive(i == currentGamePurposePage);
        }
    }

    private void UpdateMiniGameDescriptionPopup(int index)
    {
        for (int i = 0; i < miniGameDescriptionTexts[index].Length; i++)
        {
            miniGameDescriptionTexts[index][i].gameObject.SetActive(i == currentMiniGamePages[index]);
        }
    }

    private void Start()
    {
        currentMiniGamePages = new int[miniGameDescriptionPopups.Length];
    }
}
