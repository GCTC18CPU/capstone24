using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public Image characterImage;
    public Sprite[] characterSprites; // 장비에 따라 변경될 스프라이트 배열

    public void UpdateCharacterAppearance(int equipmentIndex)
    {
        if (equipmentIndex < characterSprites.Length)
        {
            characterImage.sprite = characterSprites[equipmentIndex];
        }
    }
}

