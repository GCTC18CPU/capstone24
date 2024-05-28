using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public Image characterImage;
    public Sprite[] characterSprites; // ��� ���� ����� ��������Ʈ �迭

    public void UpdateCharacterAppearance(int equipmentIndex)
    {
        if (equipmentIndex < characterSprites.Length)
        {
            characterImage.sprite = characterSprites[equipmentIndex];
        }
    }
}

