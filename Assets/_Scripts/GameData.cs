using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static int LevelIndex;
    public static int UnlockedLevels;

    private void OnEnable()
    {
        LevelIndex = PlayerPrefs.GetInt("levelIndex", 1);
        UnlockedLevels = PlayerPrefs.GetInt("unlockedLevels", 1);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("levelIndex", LevelIndex);
        PlayerPrefs.SetInt("unlockedLevels", UnlockedLevels);
    }
}
