using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static void SaveGameData(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
        PlayerPrefs.Save();
    }

    public static string LoadGameData(string key)
    {
        return PlayerPrefs.GetString(key, string.Empty);
    }
}
