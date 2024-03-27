using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static int LevelIndex = 1;

    private void OnEnable()
    {
        LevelIndex = PlayerPrefs.GetInt("levelIndex", LevelIndex);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("levelIndex", LevelIndex);
    }
}
