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

        // TextMeshProUGUI�� Ŭ�� �̺�Ʈ ������ �߰�
        dialogueText.GetComponentInParent<Button>().onClick.AddListener(DisplayNextSentence);
    }

    // ��ȭ ���� �޼���: ScriptableObject�� ����Ͽ� ��ȭ�� ����
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
            characterImage.sprite = null; // �Ǵ� �⺻ ��������Ʈ�� ����
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
        // ��ȭ ����� ������ �ڵ�
        dialogueText.text = "";
        characterImage.sprite = null; // �Ǵ� �⺻ ��������Ʈ�� ����
    }
}





