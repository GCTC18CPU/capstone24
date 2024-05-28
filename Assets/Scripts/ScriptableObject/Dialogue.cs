using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/Dialogue")]
public class Dialogue : ScriptableObject
{
    public string[] sentences;
    public Sprite characterSprite; // ���� �������� ���ܵӴϴ�.
}
