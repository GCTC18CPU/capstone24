using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/Dialogue")]
public class Dialogue : ScriptableObject
{
    public string[] sentences;
    public Sprite characterSprite; // 선택 사항으로 남겨둡니다.
}
