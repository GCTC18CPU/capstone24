using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public Image characterImage;
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();

        // TextMeshProUGUI에 클릭 이벤트 리스너 추가
        dialogueText.GetComponentInParent<Button>().onClick.AddListener(DisplayNextSentence);
    }

    // 대화 시작 메서드: ScriptableObject를 사용하여 대화를 시작
    public void StartDialogue(Dialogue dialogue)
    {
        if (dialogue == null)
        {
            Debug.LogError("Dialogue is null");
            return;
        }

        if (dialogue.characterSprite != null)
        {
            characterImage.sprite = dialogue.characterSprite;
        }
        else
        {
            characterImage.sprite = null; // 또는 기본 스프라이트로 설정
        }

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        // 대화 종료시 실행할 코드
        dialogueText.text = "";
        characterImage.sprite = null; // 또는 기본 스프라이트로 설정
    }
}





