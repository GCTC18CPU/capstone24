using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public Image characterImage;
    public Sprite[] characterSprites;
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
        StartDialogue(new string[] { "첫 번째 대사.", "두 번째 대사." }, characterSprites[0]);
    }

    public void StartDialogue(string[] dialogue, Sprite characterSprite)
    {
        characterImage.sprite = characterSprite;
        sentences.Clear();

        foreach (string sentence in dialogue)
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
        GameManager.Instance.LoadMainScene();
    }
}
